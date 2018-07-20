using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChromaCorrection
{
    public partial class Main : Form
    {
        Bitmap src;
        Bitmap composite;
        Bitmap r;
        Bitmap g;
        Bitmap b;

        public Main()
        {
            InitializeComponent();
        }

        private unsafe void button2_Click(object sender, EventArgs e)
        {

            try
            {

                OpenFileDialog of = new OpenFileDialog();
                of.Filter = "PNG|*.png|BMP|*.bmp|JPG|*.jpg";

                if (of.ShowDialog() != DialogResult.OK)
                    return;

                if (src != null)
                    src.Dispose();

                if (composite != null)
                    composite.Dispose();

                if (r != null)
                    r.Dispose();

                if (g != null)
                    g.Dispose();

                if (b != null)
                    b.Dispose();

                src = (Bitmap)Bitmap.FromFile(of.FileName);

                composite = new Bitmap(src.Width, src.Height, PixelFormat.Format32bppArgb);

                r = new Bitmap(src.Width, src.Height, PixelFormat.Format32bppArgb);
                g = new Bitmap(src.Width, src.Height, PixelFormat.Format32bppArgb);
                b = new Bitmap(src.Width, src.Height, PixelFormat.Format32bppArgb);

                var rLock = r.LockBits(new Rectangle(0, 0, src.Width, src.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
                var gLock = g.LockBits(new Rectangle(0, 0, src.Width, src.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
                var bLock = b.LockBits(new Rectangle(0, 0, src.Width, src.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
                var srcLock = src.LockBits(new Rectangle(0, 0, src.Width, src.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

                uint* rMem = (uint*)rLock.Scan0.ToPointer();
                uint* gMem = (uint*)gLock.Scan0.ToPointer();
                uint* bMem = (uint*)bLock.Scan0.ToPointer();
                uint* srcMem = (uint*)srcLock.Scan0.ToPointer();

                for (int y = 0; y < src.Height; y++)
                {
                    for (int x = 0; x < src.Width; x++)
                    {
                        var pos = x + (y * srcLock.Stride / 4);

                        var color = srcMem[pos];

                        rMem[pos] = 0xFF000000 | (color & 0xFF0000);
                        gMem[pos] = 0xFF000000 | (color & 0xFF00);
                        bMem[pos] = 0xFF000000 | (color & 0xFF);
                    }
                }

                r.UnlockBits(rLock);
                g.UnlockBits(gLock);
                b.UnlockBits(bLock);
                src.UnlockBits(srcLock);

                pbRed.Image = r;
                pbGreen.Image = g;
                pbBlue.Image = b;

                Recompose();
            }
            catch { MessageBox.Show("An error happened while processing the image"); }
        }

        unsafe void Recompose()
        {
            int xMax = composite.Width;
            int yMax = composite.Height;

            pbComposite.Image = null;

            var rLock = r.LockBits(new Rectangle(0, 0, src.Width, src.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            var gLock = g.LockBits(new Rectangle(0, 0, src.Width, src.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            var bLock = b.LockBits(new Rectangle(0, 0, src.Width, src.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            var cLock = composite.LockBits(new Rectangle(0, 0, src.Width, src.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            uint* rMem = (uint*)rLock.Scan0.ToPointer();
            uint* gMem = (uint*)gLock.Scan0.ToPointer();
            uint* bMem = (uint*)bLock.Scan0.ToPointer();
            uint* cMem = (uint*)cLock.Scan0.ToPointer();

            int pos = 0;

            for (int y = 0; y < yMax; y++)
            {
                for (int x = 0; x < xMax; x++)
                {
                    uint cr = 0;
                    uint cg = 0;
                    uint cb = 0;

                    int curX = x + (int)ndROX.Value;
                    int curY = y + (int)ndROY.Value;
                    
                    if (curX > 0 && curY > 0 && curX < xMax && curY < yMax)
                    {
                        pos = curX + (curY * rLock.Stride / 4);
                        cr = rMem[pos] & 0xFF0000;
                    }

                    curX = x + (int)ndGOX.Value;
                    curY = y + (int)ndGOY.Value;

                    if (curX > 0 && curY > 0 && curX < xMax && curY < yMax)
                    {
                        pos = curX + (curY * gLock.Stride / 4);
                        cg = gMem[pos] & 0xFF00;
                    }

                    curX = x + (int)ndBOX.Value;
                    curY = y + (int)ndBOY.Value;

                    if (curX > 0 && curY > 0 && curX < xMax && curY < yMax)
                    {
                        pos = curX + (curY * bLock.Stride / 4);
                        cb = bMem[pos] & 0xFF;
                    }

                    pos = x + (y * cLock.Stride / 4);
                    cMem[pos] = 0xFF000000 | cr | cg | cb;
                }

            }

            pbComposite.Image = composite;

            r.UnlockBits(rLock);
            g.UnlockBits(gLock);
            b.UnlockBits(bLock);
            composite.UnlockBits(cLock);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (composite == null)
            {
                MessageBox.Show("No image loaded");
                return;
            }

            Recompose();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (composite == null)
            {
                MessageBox.Show("No image loaded");
                return;
            }

            try
            {

                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "PNG|*.png";

                if (sf.ShowDialog() != DialogResult.OK)
                    return;

                composite.Save(sf.FileName, ImageFormat.Png);
            }
            catch { MessageBox.Show("An error happened while trying to save image"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (composite == null)
            {
                MessageBox.Show("No image loaded");
                return;
            }

            try
            {

                ndROY.Value += 1;
                ndBOY.Value -= 1;

                Recompose();
            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (composite == null)
            {
                MessageBox.Show("No image loaded");
                return;
            }

            try
            {

                ndROY.Value -= 1;
                ndBOY.Value += 1;

                Recompose();
            }
            catch { }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (composite == null)
            {
                MessageBox.Show("No image loaded");
                return;
            }

            try
            {

                ndROX.Value -= 1;
                ndBOX.Value += 1;

                Recompose();
            }
            catch { }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (composite == null)
            {
                MessageBox.Show("No image loaded");
                return;
            }

            try
            {

                ndROX.Value += 1;
                ndBOX.Value -= 1;

                Recompose();
            }
            catch { }
        }
    }
}
