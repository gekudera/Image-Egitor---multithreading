using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
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
           
        }

        public Image Copy(Image a)
        {
            for (int j = 0; j < input.Height; j++)
                for (int i = 0; i < input.Width; i++)
                {
                    a.A[i,j] = this.A[i,j];
                    a.R[i,j] = this.R[i,j];
                    a.G[i,j] = this.G[i,j];
                    a.B[i,j] = this.B[i,j];
                }
            return a;
        }

    }
}
