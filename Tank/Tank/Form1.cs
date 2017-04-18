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

namespace Tank
{
    public partial class Form1 : Form
    {
        TankGame tanks = new TankGame();
        Graphics gpic;
        Bitmap bitmap;
        Graphics G;
        public int k = 1;
        KeyEventArgs keypressed;
        public Form1()
        {
            InitializeComponent();
            G = this.CreateGraphics();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (k == 4)
            {
                tanks.MoveDown(e.Graphics);
            }
            if (k == 3)
            {
                tanks.MoveUp(e.Graphics);
            }
            if (k == 1)
            {
                tanks.MoveRight(e.Graphics);
            }
            if (k == 2)
            {
                tanks.MoveLeft(e.Graphics);
            }
        }
        private void DownKey(object sender, KeyEventArgs g, PaintEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (k == 1)
            {
                tanks.location.X += 10;
            }
            if (k == 4)
            {
                tanks.location.Y += 10;
            }
            if (k == 2)
            {
                tanks.location.X -= 10;
            }
            if (k == 3)
            {
                tanks.location.Y -= 10;
            }
            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                k = 1;
            }
            if (e.KeyCode == Keys.Left)
            {
                k = 2;
            }
            if (e.KeyCode == Keys.Up)
            {
                k = 3;
            }
            if (e.KeyCode == Keys.Down)
            {
                k = 4;
            }
        }

    }
}
