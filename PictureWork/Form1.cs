using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PictureWork
{

    public partial class Form1 : Form
    {
        static int h, w, p=3;
        static Image img;
        int blurAmount = 1;
        MyThread[] mt = new MyThread[p];


        public Form1()
        {
            InitializeComponent();
        }


        private int[,] GetIndex(int p)
        {
            int np = picBox1.Image.Height / p;
            int[,] indexes = new int[p, 2]; // объявление двумерного массива
            for (int i = 0; i < p; i++)
            {
                if (i == p - 1)
                {
                    indexes[i, 0] = np * i;
                    indexes[i, 1] = picBox1.Image.Height;
                }
                else
                {
                    indexes[i, 0] = np * i;
                    indexes[i, 1] = (np * (i + 1)) - 1;
                }
            }
            
            return indexes;
            
        }

        private void OpenBut_Click(object sender, EventArgs e)
        {
            // диалог для выбора файла
            OpenFileDialog ofd = new OpenFileDialog();
            // фильтр форматов файлов
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            // если в диалоге была нажата кнопка ОК
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // загружаем изображение
                    picBox1.Image = new Bitmap(ofd.FileName);
                    w = (picBox1.Image).Width;
                    h = (picBox1.Image).Height;
                    Bitmap input = new Bitmap(picBox1.Image);
                    img =new Image(input);
                    MessageBox.Show("Картинка загружена!");

                }
                catch // в случае ошибки выводим MessageBox
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
            if (picBox2.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Сохранить картинку как...";
                sfd.OverwritePrompt = true; // показывать ли "Перезаписать файл" если пользователь указывает имя файла, который уже существует
                sfd.CheckPathExists = true; // отображает ли диалоговое окно предупреждение, если пользователь указывает путь, который не существует
                                            // фильтр форматов файлов
                sfd.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                sfd.ShowHelp = true; // отображается ли кнопка Справка в диалоговом окне
                                     // если в диалоге была нажата кнопка ОК
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // сохраняем изображение
                        picBox2.Image.Save(sfd.FileName);
                    }
                    catch // в случае ошибки выводим MessageBox
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ModBut_Click(object sender, EventArgs e)
        {
            Bitmap output1 = new Bitmap(w, h);
            if (picBox1.Image != null) // если изображение в pictureBox1 имеется
            {
                // перебираем в циклах все пиксели исходного изображения ось Х из левого верзнего угла вправо, Y - вниз
                for (int j = 0; j < h; j++) 
                    for (int i = 0; i < w; i++)
                    {
                       // делаем цвет черно-белым (оттенки серого) - находим среднее арифметическое
                        img.R[i,j] = img.G[i,j] = img.B[i,j] = (img.R[i,j] + img.G[i,j] + img.B[i,j]) / 3.0f;
                        // собираем новый пиксель по частям (по каналам)
                        UInt32 newPixel = 0xFF000000 | ((UInt32)img.R[i,j] << 16) | ((UInt32)img.G[i,j] << 8) | ((UInt32)img.B[i,j]);
                        // добавляем его в Bitmap нового изображения
                        output1.SetPixel(i, j, Color.FromArgb((int)newPixel));
                    }
                picBox2.Image = output1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (picBox1.Image != null) 
            {
                picBox2.Image = (Bitmap)picBox1.Image.Clone();
            }
        }

        private void BlurBut_Click(object sender, EventArgs e)
        {
            int[,] ind = GetIndex(p);
            for (int i = 0; i < p; i++)
            {
                mt[i] = new MyThread(img, blurAmount, ind[i,0], ind[i,1], p);
            }
            for (int i = 0; i < p; i++)
                mt[i].T1.Join();

            //picBox2.Image = mt[1].getBMP();

            Bitmap bm = new Bitmap(picBox1.Image.Width, picBox1.Image.Height);
            for (int i = 0; i < p; i++)
            {
                Bitmap bm1 = mt[i].getBMP();
                Graphics g = Graphics.FromImage(bm);
                if (i == 0)
                    g.DrawImage(bm1, 0, 0, picBox1.Image.Width, bm1.Height);
                else
                    g.DrawImage(bm1, 0, i*mt[i-1].bmp.Height-blurAmount, picBox1.Image.Width, bm1.Height);
                g.Dispose();
            }
            picBox2.Image = bm;
        }

        private void updateBlur(object sender, EventArgs e)
        {
            blurAmount = int.Parse(trackBar1.Value.ToString())*2;
        }

        private void prBut_Click(object sender, EventArgs e)
        {
            if (picBox1.Image != null) 
            {
                Bitmap output2 = new Bitmap(w, h);
                int chisl = Convert.ToInt32(Num1.Value);
                // перебираем в циклах все пиксели исходного изображения ось Х из левого верзнего угла вправо, Y - вниз
                for (int j = 0; j < h; j++)
                    for (int i = 0; i < w; i++)
                    {
                        img.A[i, j] = chisl * 0.01f * img.A[i, j];
                        // собираем новый пиксель по частям (по каналам)
                        UInt32 newPixel = ((UInt32)img.A[i, j] << 24) | ((UInt32)img.R[i, j] << 16) | ((UInt32)img.G[i, j] << 8) | ((UInt32)img.B[i, j]);
                        // добавляем его в Bitmap нового изображения
                        output2.SetPixel(i, j, Color.FromArgb((int)newPixel));
                    }
                picBox2.Image = output2;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
