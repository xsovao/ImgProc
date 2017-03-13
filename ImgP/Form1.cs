

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgP
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Bitmap gray;
        int[,] gdata;
        int[] hist = new int[256];
        float[] histcum = new float[256];
        int[] histEq = new int[256];
        int min;
        int max;
        bool loaded = false;
        string lastop;
        public Form1()
        {
            InitializeComponent();
        }

        private void menu_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if(bmp!=null)bmp.Dispose();
                if (gray != null) gray.Dispose();
                bmp = new Bitmap(ofd.FileName.ToString());
                gray = grayscale(bmp);
                img_main.Image = gray;
                img_main.Refresh();
                hist = new int[256];
                histEq = new int[256];
                histcum = new float[256];
                loaded = true;
                img_hist.BackColor = Color.White;
                calcHist();
                drawHist(hist);
                lastop = "Original";
            }
            img_main.Select();
            ofd.Dispose();
        }

        private void redraw()
        {
            int v;
            for (int x = 0; x < gray.Width; x++)
                for (int y = 0; y < gray.Height; y++)
                {
                    v = gdata[x, y];
                    gray.SetPixel(x,y,Color.FromArgb(v,v,v));
                }
            calcHist();
            drawHist(hist);
            img_main.Image = gray;
            img_main.Refresh();
        }

        private Bitmap grayscale(Bitmap original)
        {
            Color c;
            int val;
            Bitmap g = new Bitmap(original.Width, original.Height);
            gdata = new int[g.Width,g.Height];
            for (int x = 0; x < original.Width; x++)
                for (int y = 0; y < original.Height; y++)
                {
                    c = original.GetPixel(x, y);
                    val = Math.Min(255,(c.R + c.G + c.B) / 3);
                    g.SetPixel(x, y, Color.FromArgb(val, val, val));
                    gdata[x, y] = val;
                }
            return g;
        }

        private void calcHist()
        {
            for (int i = 0; i < 256; i++) hist[i] = 0;       //vypocet hist
            for (int x = 0; x < gray.Width; x++)
                for (int y = 0; y < gray.Height; y++) {
                    hist[gdata[x, y]]++;
                }

            int norm = gray.Width * gray.Height;
            int sum = 0;

            for (int i = 0; i < 256; i++) {     //vypocet kumul.hist
                sum += hist[i];
                histcum[i] = (float)sum;
                    }

            lastop = "Cumulative";    //predtym, ako sa znormuje, zapis kumulativny hist do histCumulative.txt
            writeHist(histcum);

            for (int i = 0; i < 256; i++)          //normuj
            {
                histcum[i] = (float)histcum[i] / norm;
            }
                for (int i = 0; i < 256; i++) histEq[i] = (int)(255 * histcum[i] + 0.5F);
                setminmax();
        }

        private void drawHist(int[] hist) {
            Bitmap histimg = new Bitmap(256, 256);
            Graphics gfx = Graphics.FromImage(histimg);
            float scale = 1.0F;
            int maxval = 0;
            for(int i=0; i<256; i++)if (hist[i] > maxval) maxval = hist[i];
            scale = 256.0F/maxval;
            gfx.Clear(Color.White);
            for (int i = 0; i < 256; i++)
            {
                gfx.FillRectangle(Brushes.Black, i, 256 - hist[i] * scale, 1, hist[i] * scale);
            }
            img_hist.Image = histimg;
            img_hist.Refresh();
            gfx.Dispose();
        }

        private void writeHist(int[] hist)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("hist"+lastop+".txt");
            for (int i = 0; i < 256; i++) file.WriteLine(Convert.ToString(i)+" : "+Convert.ToString(hist[i]));
            file.Close();
        }
        private void writeHist(float[] hist)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("hist" + lastop + ".txt");
            for (int i = 0; i < 256; i++) file.WriteLine(Convert.ToString(i) + " : " + Convert.ToString(hist[i]));
            file.Close();
        }

        private void setminmax()
        {
            for (int i = 0; i < 256; i++) if (hist[i] != 0) max = i;
            for (int i = 255; i >= 0; i--) if (hist[i] != 0) min = i;
            minlabel.Text = min.ToString();
            maxlabel.Text = max.ToString();
        }

        private int[,] convolve(double[,] cm, int rad) {
            int[,] r = new int[gray.Width, gray.Height];
            int xx, yy;
            double v;
            for (int x = 0; x < gray.Width; x++)
                for (int y = 0; y < gray.Height; y++)
                {
                    
                    v = 0;
                    for (int i = 0; i <= 2 * rad; i++)
                        for (int j = 0; j <= 2 * rad; j++)
                        {
                            xx = x + i - rad;
                            yy = y + j - rad;
                            if (xx < 0 || xx > gray.Width-1) xx = x - i + rad;
                            if (yy < 0 || yy > gray.Height-1) yy = y - j + rad;

                            if (cm[i, j] != 0)
                                v += (cm[i, j] * gdata[xx, yy]);
                            r[x, y] = (int)(Math.Min(255, Math.Max(0, v)));
                        }
                }
                    return r;
        }
        private void originalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                gray = grayscale(bmp);
                redraw();
                lastop = "Original";
            }
        }

        #region HIST_OPS
        private void fSHSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                for (int x = 0; x < gray.Width; x++)
                    for (int y = 0; y < gray.Height; y++)
                    {
                        gdata[x, y] = Math.Max(0, Math.Min(255, (int)(255.0F / (max - min) * (gdata[x, y] - min))));
                    }
                redraw();
                lastop = "FHSH";
                writeHist(hist);
            }
        }

        private void equalizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                for (int x = 0; x < gray.Width; x++)
                    for (int y = 0; y < gray.Height; y++)
                    {
                        gdata[x, y] = (int)histEq[gdata[x, y]];
                    }
                redraw();
                lastop = "Equalize";
                writeHist(hist);
            }
        }

        private void writetxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writeHist(hist);
        }
        #endregion
        #region BLUR


        private void uniform3x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                double[,] cm = new double[,] {
                  { 1.0/9, 1.0/9, 1.0/9 },
                  { 1.0/9, 1.0/9, 1.0/9 },
                  { 1.0/9, 1.0/9, 1.0/9 }
                   };
                gdata = convolve(cm, 1);
                redraw();
                lastop = "Blur3x3";
            }
        }
             private void diamond13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                double v = 1.0 / 13;
                double[,] cm = new double[,] {
                  { 0, 0, v,0,0 },
                  { 0, v, v,v,0 },
                  { v, v,v,v,v },
                  { 0,v,v,v,0 },
                  { 0,0,v,0,0 } };
                gdata = convolve(cm, 2);
                redraw();
                lastop = "Blur5x5";
            }
        }
        #endregion
        #region SHARPEN

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                double[,] cm = new double[,] {
                  { 0, -1, 0 },
                  { -1, 5, -1 },
                  { 0, -1, 0 }
                   };
                gdata = convolve(cm, 1);
                redraw();
                lastop = "Shapen3x3";
            }
        }
        private void x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                double a = -1.0/8, b = 2.0/8, c = 1.0; 
                double[,] cm = new double[,] {
                  { a, a, a,a,a },
                  { a, b, b,b,a },
                  { a, b,c,b,a },
                  { a, b, b,b,a },
                 { a, a, a,a,a }};
                gdata = convolve(cm, 2);
                redraw();
                lastop = "Shapen5x5";
            }
        }
        #endregion
        #region EDGE DETECT
        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                double[,] cm = new double[,] {
                  { 0, 0, 0,0,0 },
                  { 0, 0, 0,0,0 },
                  { -1, -1,4,-1,-1 },
                  { 0,0,0,0,0 },
                  { 0,0,0,0,0 } };
                gdata = convolve(cm, 2);
                redraw();
                lastop = "EdgeHorizontal";
            }
        }

        private void diagonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                double[,] cm = new double[,] {
                  { -1, 0, 0,0,0 },
                  { 0, -2, 0,0,0 },
                  { 0, 0,6,0,0 },
                  { 0,0,0,-2,0 },
                  { 0,0,0,0,-1 } };
                gdata = convolve(cm, 2);
                redraw();
                lastop = "EdgeDiagonal";
            }
        }
        private void laplace4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                double[,] cm = new double[,] {
                  { 0, 1, 0 },
                  { 1, -4, 1 },
                  { 0, 1, 0 }
                   };
                gdata = convolve(cm, 1);
                redraw();
                lastop = "EdgeLaplace4";
            }
        }
        private void laplace8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                double[,] cm = new double[,] {
                  { 1, 1, 1 },
                  { 1, -8, 1 },
                  { 1, 1, 1 }
                   };
                gdata = convolve(cm, 1);
                redraw();
                lastop = "EdgeLaplace8";
            }
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                double[,] cm = new double[,] {
                  { 1, 2, 1 },
                  { 0,0, 0 },
                  { -1, -2, -1 }
                   };
                gdata = convolve(cm, 1);
                cm = new double[,] {
                  { -1, 0, 1 },
                  { -2,0, 2 },
                  { -1, 0, 1 }
                   };
                gdata = convolve(cm, 1);
                redraw();
                lastop = "EdgeSobel";
            }
        }


        #endregion
        #region EMBOSS
        private void x3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                double[,] cm = new double[,] {
                  { -2, -1, 0 },
                  { -1, 1, 1 },
                  { 0, 1, 2 }
                   };
                gdata = convolve(cm, 1);
                redraw();
                lastop = "Emboss3x3";
            }
        }

        private void x5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                double[,] cm = new double[,] {
                  { -1,-1, -1,-1,0 },
                  { -1, -1, -1,0,1 },
                  { -1, -1,0,1,1 },
                  { -1,0,1,1,1 },
                  { 0,1,1,1,1 } };
                gdata = convolve(cm, 2);
                redraw();
                lastop = "Emboss5x5";
            }
        }

        #endregion

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
