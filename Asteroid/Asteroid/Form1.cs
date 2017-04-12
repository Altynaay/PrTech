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
        asteroidgame asteroids = new asteroidgame();
        Bullet bullet;
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
            /*asteroids.Ellipse(g.Graphics);
            asteroids.Polygon(g.Graphics);
            asteroids.strelka(g.Graphics);
            asteroids.Asters(g.Graphics);
            asteroids.Bullet(g.Graphics);
            Refresh();*/
        }

        private void DownKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

            }
        }

    }
}
