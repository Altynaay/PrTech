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
using System.Drawing;

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
            asteroids.Bullet(e.Graphics);
            asteroids.strelka(e.Graphics);
            asteroids.Asters(e.Graphics);
        }

    }
}
