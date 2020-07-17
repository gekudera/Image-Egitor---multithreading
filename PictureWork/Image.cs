using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PictureWork
{
    class Image
    {
        public Bitmap input;

        public float[,] A;

        public float[,] R;

        public float[,] G;

        public float[,] B;



        public Image(Bitmap inp)
        {
            input = inp;
            A = new float[input.Width, input.Height];
            B = new float[input.Width, input.Height];
            R = new float[input.Width, input.Height];
            G = new float[input.Width, input.Height];

            for (int j = 0; j < input.Height; j++)
                for (int i = 0; i < input.Width; i++)
                {
                    UInt32 pixel = (UInt32)(input.GetPixel(i, j).ToArgb());
                    A[i, j] = (float)((pixel & 0xFF000000) >> 24); // прозрачность Alpha
                    R[i, j] = (float)((pixel & 0x00FF0000) >> 16); // красный RED в диапозоне от 0 до 255
                    G[i, j] = (float)((pixel & 0x0000FF00) >> 8); // зеленый GREEN от 0 до 255
                    B[i, j] = (float)(pixel & 0x000000FF); // синий BLUE от 0 до 255


                }
        }
    }
}
