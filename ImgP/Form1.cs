

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
                img_hist.BackColor = Color.White;
                calcHist();
                drawHist(hist);
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
            for (int i = 0; i < 256; i++) hist[i] = 0;
            for (int x = 0; x < gray.Width; x++)
                for (int y = 0; y < gray.Height; y++) {
                    hist[gdata[x, y]]++;
                }
            int norm = gray.Width * gray.Height;
            int sum = 0;
            for (int i = 0; i < 256; i++) {
                sum += hist[i];
                histcum[i] = (float)sum / norm;
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
                gfx.FillRectangle(Brushes.Black, 1 + i, 256 - hist[i] * scale, 1, hist[i] * scale);
            }
            img_hist.Image = histimg;
            img_hist.Refresh();
            gfx.Dispose();
        }

        private void setminmax()
        {
            for (int i = 0; i < 256; i++) if (hist[i] != 0) max = i;
            for (int i = 255; i >= 0; i--) if (hist[i] != 0) min = i;
            minlabel.Text = min.ToString();
            maxlabel.Text = max.ToString();
        }

        private void revertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gray = grayscale(bmp);
            redraw();
        }

        private void fSHSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < gray.Width; x++)
                for (int y = 0; y < gray.Height; y++)
                {
                    gdata[x, y] = Math.Max(0,Math.Min(255,(int)(255.0F / (max - min) * (gdata[x, y] - min))));
                }
            redraw();
        }

        private void equalizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < gray.Width; x++)
                for (int y = 0; y < gray.Height; y++)
                {
                        gdata[x, y] = (int)histEq[gdata[x, y]];
                }
            redraw();
        }
    }
}
