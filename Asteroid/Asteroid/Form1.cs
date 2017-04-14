using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Asteroid
{
    public partial class Form1 : Form
    {
        Bullet bullet;
        asteroidgame asteroids = new asteroidgame();
        SolidBrush brushgreen  = new SolidBrush(Color.Green);
        Bitmap bitmap;
        Graphics bitG;

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bitG = Graphics.FromImage(bitmap);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            asteroids.ellip.X++;   asteroids.ellip.Y++;

            asteroids.ellip2.X++;  asteroids.ellip2.Y--;

            asteroids.ellip3.X--;  asteroids.ellip3.Y++;

            asteroids.ellip4.X--;  asteroids.ellip4.Y--;

            asteroids.star.X++;    asteroids.star.Y++;

            asteroids.star2.X++;   asteroids.star2.Y--;

            asteroids.star3.X--;   asteroids.star3.Y--;

            asteroids.star4.X--;   asteroids.star4.Y++;

            asteroids.raketa.X++;  asteroids.raketa.Y++;

            asteroids.Ellipse(bitG);
            asteroids.Polygon(bitG);
            asteroids.strelka(bitG);
            asteroids.Asters(bitG);
            asteroids.Bullet(bitG);
            pictureBox1.Image = bitmap;
        }
        

        private void DownKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                
            }
        }

    }
}
