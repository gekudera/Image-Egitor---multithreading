using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace PictureWork
{
    class MyThread
    {
        public Thread T1;

        public Bitmap bmp;

        private Image im;

        private int blur;

        private int left, right;


        public MyThread(Image img, int blurAmount, int start, int end, int p)
        {
            im = img;
            left = start;
            right = end;
            blur = blurAmount;
            bmp = new Bitmap(img.input.Width,end-start); 
            T1 = new Thread(this.Run);
            T1.Start(); //начать поток
        }

        
        private void Run()
        {
            Blur(bmp);

        }

        private void Blur(Bitmap bmp)
        {
           
            for (int i = blur; i < (bmp.Width - blur); i++)
            {
                int m = 0;
                for (int j = left; j < right; j++)
                {
                    int avgR, avgG, avgB;
                    try
                    {
                        if (j <= (left + blur))
                        {

                            avgR = (int)((im.R[i - blur, j] + im.R[i + blur, j]
                            + im.R[i, j + blur] + im.R[i + blur, j + blur] + im.R[i - blur, j + blur]) / 5);
                            avgG = (int)((im.G[i - blur, j] + im.G[i + blur, j]
                            + im.G[i, j + blur] + im.G[i + blur, j + blur] + im.G[i - blur, j + blur]) / 5);
                            avgB = (int)((im.B[i - blur, j] + im.B[i + blur, j]
                            + im.B[i, j + blur] + im.B[i + blur, j + blur] + im.B[i - blur, j + blur]) / 5);

                        }
                        else if (j >= (right - blur))
                        {
                            avgR = (int)((im.R[i - blur, j] + im.R[i + blur, j]
                            + im.R[i, j - blur] + im.R[i + blur, j - blur] + im.R[i - blur, j - blur]) / 5);
                            avgG = (int)((im.G[i - blur, j] + im.G[i + blur, j]
                            + im.G[i, j - blur] + im.G[i + blur, j - blur] + im.G[i - blur, j - blur]) / 5);
                            avgB = (int)((im.B[i - blur, j] + im.B[i + blur, j]
                            + im.B[i, j - blur] + im.B[i + blur, j - blur] + im.B[i - blur, j - blur]) / 5);
                        }

                        else
                        {
                            avgR = (int)((im.R[i - blur, j] + im.R[i + blur, j] + im.R[i, j - blur]
                                + im.R[i, j + blur] + im.R[i + blur, j - blur] + im.R[i + blur, j + blur]
                                + im.R[i - blur, j - blur] + im.R[i - blur, j + blur]) / 8);

                            avgG = (int)((im.G[i - blur, j] + im.G[i + blur, j] + im.G[i, j - blur]
                                + im.G[i, j + blur] + im.G[i + blur, j - blur] + im.G[i + blur, j + blur]
                                + im.G[i - blur, j - blur] + im.G[i - blur, j + blur]) / 8);

                            avgB = (int)((im.B[i - blur, j] + im.B[i + blur, j] + im.B[i, j - blur]
                                + im.B[i, j + blur] + im.B[i + blur, j - blur] + im.B[i + blur, j + blur]
                                + im.B[i - blur, j - blur] + im.B[i - blur, j + blur]) / 8);
                        }

                        bmp.SetPixel(i, m, Color.FromArgb(avgR, avgG, avgB));
                    }
                    catch (Exception) 
                    {
                        MessageBox.Show(i+ "   " + j + "  " + right);
                    }
                    m++;
                }
            }
        }

        public Bitmap getBMP()
        {
            return bmp;
        }
    }
}
