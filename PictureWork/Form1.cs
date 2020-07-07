using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureWork
{

    public partial class Form1 : Form
    {
        static int h, w, changeimg = 0;
        static float[,] A;
        static float[,] R;
        static float[,] G;
        static float[,] B;

        public Form1()
        {
            InitializeComponent();
        }

        public void GetRGBA()
        {
            // создаём Bitmap из изображения, находящегося в pictureBox1
            Bitmap input = new Bitmap(picBox1.Image);
            for (int j = 0; j < input.Height; j++)
                for (int i = 0; i < input.Width; i++)
                {
                    // получаем (i, j) пиксель
                    UInt32 pixel = (UInt32)(input.GetPixel(i, j).ToArgb());
                    // получаем компоненты цветов пикселя
                    A[i, j] = (float)((pixel & 0xFF000000) >> 24); // прозрачность Alpha
                    R[i, j] = (float)((pixel & 0x00FF0000) >> 16); // красный RED в диапозоне от 0 до 255
                    G[i, j] = (float)((pixel & 0x0000FF00) >> 8); // зеленый GREEN от 0 до 255
                    B[i, j] = (float)(pixel & 0x000000FF); // синий BLUE от 0 до 255
                }
            changeimg = 0;
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
                    A = new float[w, h];
                    R = new float[w, h];
                    G = new float[w, h];
                    B = new float[w, h];
                    changeimg = 1;
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
            if (picBox1.Image != null) // если изображение в pictureBox1 имеется
            {
                // создаём Bitmap для черно-белого изображения
                Bitmap output = new Bitmap(w, h);
                if (changeimg == 1)
                {
                    GetRGBA();
                }
                // перебираем в циклах все пиксели исходного изображения ось Х из левого верзнего угла вправо, Y - вниз
                for (int j = 0; j < h; j++) 
                    for (int i = 0; i < w; i++)
                    {
                       // делаем цвет черно-белым (оттенки серого) - находим среднее арифметическое
                        R[i,j] = G[i,j] = B[i,j] = (R[i,j] + G[i,j] + B[i,j]) / 3.0f;
                        // собираем новый пиксель по частям (по каналам)
                        UInt32 newPixel = 0xFF000000 | ((UInt32)R[i,j] << 16) | ((UInt32)G[i,j] << 8) | ((UInt32)B[i,j]);
                        // добавляем его в Bitmap нового изображения
                        output.SetPixel(i, j, Color.FromArgb((int)newPixel));
                    }
                picBox2.Image = output;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (picBox1.Image != null) 
            {
                picBox2.Image = (Bitmap)picBox1.Image.Clone();
            }
        }

        private void prBut_Click(object sender, EventArgs e)
        {
            if (picBox1.Image != null) 
            {
                // создаём Bitmap для прозрачного изображения
                Bitmap output = new Bitmap(w, h);
                if (changeimg == 1)
                {
                    GetRGBA();
                }
                int chisl = Convert.ToInt32(Num1.Value);
                if (chisl == 0) changeimg = 1;
                // перебираем в циклах все пиксели исходного изображения ось Х из левого верзнего угла вправо, Y - вниз
                for (int j = 0; j < h; j++)
                    for (int i = 0; i < w; i++)
                    {
                        A[i, j] = chisl * 0.01f * A[i, j];
                        // собираем новый пиксель по частям (по каналам)
                        UInt32 newPixel = ((UInt32)A[i, j] << 24) | ((UInt32)R[i, j] << 16) | ((UInt32)G[i, j] << 8) | ((UInt32)B[i, j]);
                        // добавляем его в Bitmap нового изображения
                        output.SetPixel(i, j, Color.FromArgb((int)newPixel));
                    }
                picBox2.Image = output;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
