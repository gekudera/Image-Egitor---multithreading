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
using System.Diagnostics;

namespace PictureWork
{

    public partial class Form1 : Form
    {
        static Image img; //изменяемое изображение
        static Image first; //изображение в первом пикчербокс
        int blurAmount = 1;
        static Stopwatch sw = new Stopwatch();

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

        private int GetP()
        {
            int p;
            int S = img.input.Width * img.input.Height;

            if (S <= 800000)
                p = 2;
            else if ((S > 800000) && (S <= 25000000))
                p = 4;
            else p = 6;

            return p;
        }

        private async void OpenBut_Click(object sender, EventArgs e)
        {
            picBox2.Image = null;
            // диалог для выбора файла
            OpenFileDialog ofd = new OpenFileDialog();
            // фильтр форматов файлов
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            // если в диалоге была нажата кнопка ОК
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    OpenBut.Enabled = SaveBut.Enabled = button1.Enabled = WhiteBlackBut.Enabled= BlurBut.Enabled = prBut.Enabled= false;
                    // загружаем изображение
                    picBox1.Image = new Bitmap(ofd.FileName);
                    Bitmap input = new Bitmap(picBox1.Image);
                    img = new Image(input);
                    await Task.Run(() => { RunProcessing(input); });
                    first = new Image(input);
                    img.Copy(first);
                    OpenBut.Enabled = SaveBut.Enabled = button1.Enabled = WhiteBlackBut.Enabled = BlurBut.Enabled = prBut.Enabled= true;
                    MessageBox.Show("Картинка загружена!");

                }
                catch // в случае ошибки выводим MessageBox
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void RunProcessing(Bitmap input)
        {
            for (int j = 0; j < input.Height; j++)
                for (int i = 0; i < input.Width; i++)
                {
                    UInt32 pixel = (UInt32)(input.GetPixel(i, j).ToArgb());
                    img.A[i, j] = (float)((pixel & 0xFF000000) >> 24); // прозрачность Alpha
                    img.R[i, j] = (float)((pixel & 0x00FF0000) >> 16); // красный RED в диапозоне от 0 до 255
                    img.G[i, j] = (float)((pixel & 0x0000FF00) >> 8); // зеленый GREEN от 0 до 255
                    img.B[i, j] = (float)(pixel & 0x000000FF); // синий BLUE от 0 до 255
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
            int w = picBox1.Image.Width;
            int h = picBox1.Image.Height;
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
                first.Copy(img);
            }
        }

        private void BlurBut_Click(object sender, EventArgs e)
        {
            int p = GetP();
            int[,] ind = GetIndex(p);
            MyThread[] mt = new MyThread[p];
            sw.Start();
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
            RunProcessing(bm); //перерасчет АРГБ
            sw.Stop();
            long time = sw.ElapsedMilliseconds;
            MessageBox.Show("Время работы " + p + " потоков: " + time);
        }

        private void updateBlur(object sender, EventArgs e)
        {
            blurAmount = int.Parse(trackBar1.Value.ToString())*2;
        }

        private void prBut_Click(object sender, EventArgs e)
        {
            if (picBox1.Image != null) 
            {
                int w = picBox1.Image.Width;
                int h = picBox1.Image.Height;
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
                if (chisl==0)
                    img = new Image((Bitmap)picBox1.Image.Clone());
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
