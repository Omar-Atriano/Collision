using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colision
{
    
    public partial class Form1 : Form
    {
        static Graphics g;
        Bitmap bmp;
        int loc1,loc2 = 25;
        int locx2, locy2 = 300;
        int locx3 = 70;
        int locy3 = 70;
        int locx4 = 500;
        int locy4 = 80;
        int locx5 = 300;
        int locy5 = 200;
        int xVel = 6;
        int yVel = 6;
        int xVel2 = 5;
        int yVel2 = 5;
        int xVel3 = 1;
        int yVel3 = 1;
        int xVel4 = 4;
        int yVel4 = 1;
        int xVel5 = 2;
        int yVel5 = 3;
        Ellipse ellipse = new Ellipse(20, 20);
        Ellipse ellipse2 = new Ellipse(30, 30);
        Ellipse ellipse3 = new Ellipse(50, 50);
        Ellipse ellipse4 = new Ellipse(25, 25);
        Ellipse ellipse5 = new Ellipse(35, 35);


        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.Black);
            loc1 += xVel;
            loc2 += yVel;
            locx2 += xVel2;
            locy2 += yVel2;
            locx3 += xVel3;
            locy3 += yVel3;
            locx4 += xVel4;
            locy4 += yVel4;
            locx5 += xVel5;
            locy5 += yVel5;

            //bola 1
            if (loc1 + ellipse.GetWidth() >= pictureBox1.Width || loc1 <=0)
            {
                xVel = -xVel;

            }
            if(loc2 + ellipse.GetHeight() >= pictureBox1.Height || loc2  <= 0)
            {
                yVel = -yVel;
            }
            //Bola 2
            if (locx2 + ellipse2.GetWidth() >= pictureBox1.Width || locx2 <= 0)
            {
                xVel2 = -xVel2;
            }
            if (locy2 + ellipse2.GetHeight() >= pictureBox1.Height || locy2 <= 0)
            {
                yVel2 = -yVel2;
            }
            //Bola3
            if (locx3 + ellipse3.GetWidth() >= pictureBox1.Width || locx3 <= 0)
            {
                xVel3 = -xVel3;
            }
            if (locy3 + ellipse3.GetHeight() >= pictureBox1.Height || locy3 <= 0)
            {
                yVel3 = -yVel3;
            }
            //Bola 4
            if (locx4 + ellipse4.GetWidth() >= pictureBox1.Width || locx4 <= 0)
            {
                xVel4 = -xVel4;
            }
            if (locy4 + ellipse4.GetHeight() >= pictureBox1.Height || locy4 <= 0)
            {
                yVel4 = -yVel4;
            }
            //Bola 5
            if (locx5 + ellipse5.GetWidth() >= pictureBox1.Width || locx5 <= 0)
            {
                xVel5 = -xVel5;
            }
            if (locy5 + ellipse5.GetHeight() >= pictureBox1.Height || locy5 <= 0)
            {
                yVel5 = -yVel5;
            }

            g.FillEllipse(Brushes.Red, loc1, loc2, ellipse.GetWidth(), ellipse.GetHeight());
            g.FillEllipse(Brushes.Green, locx2, locy2, ellipse2.GetWidth(), ellipse2.GetHeight());
            g.FillEllipse(Brushes.Blue, locx3, locy3, ellipse3.GetWidth(), ellipse3.GetHeight());
            g.FillEllipse(Brushes.Yellow, locx4, locy4, ellipse4.GetWidth(), ellipse4.GetHeight());
            g.FillEllipse(Brushes.White, locx5,locy5, ellipse5.GetWidth(), ellipse5.GetHeight());
            pictureBox1.Invalidate();
        }


        
    }
}
