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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            asteroids.Ellipse(e.Graphics);
            asteroids.Polygon(e.Graphics);
            asteroids.strelka(e.Graphics);
            asteroids.Asters(e.Graphics);
            asteroids.Bullet(e.Graphics);
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

            asteroids.raketa.X++;
            asteroids.raketa.Y++;

            Refresh();
        }
        

        private void DownKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                
            }
        }

    }
}
