using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawCirclePxFrm
{
    public partial class Drawcircle : Form
    {
        public Drawcircle()
        {
            InitializeComponent();
        }

        void PutPixel(Graphics g, int x, int y, Color c)
        {
            Bitmap bm = new Bitmap(1, 1);
            bm.SetPixel(0, 0, Color.Yellow);
            g.DrawImageUnscaled(bm, x, y);
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.Clear(Color.Black);
            double radius = 40;
            for (int j = 1; j <= 25; j++)
            {
                radius = (j + 1) * 5;
                for (double i = 0.0; i < 360.0; i += 0.1)
                {
                    double angle = i * System.Math.PI / 180;
                    int x = (int)(150 + radius * System.Math.Cos(angle));
                    int y = (int)(150 + radius * System.Math.Sin(angle));
                    PutPixel(g, x, y, Color.Red);
                }
            }
            g.Dispose();
        }
    }
}
