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
        public int k = 1, s = 4;
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
            //k
            if (k == 1)
            {
                tanks.MoveRight(e.Graphics);
            }
            if (k == 2)
            {
                tanks.MoveLeft(e.Graphics);
            }
            if (k == 3)
            {
                tanks.MoveUp(e.Graphics);
            }
            if (k == 4)
            {
                tanks.MoveDown(e.Graphics);
            }
            //s
            if (s == 1)
            {
                tanks.MoveRight2(e.Graphics);
            }
            if (s == 2)
            {
                tanks.MoveLeft2(e.Graphics);
            }
            if (s == 3)
            {
                tanks.MoveUp2(e.Graphics);
            }
            if (s == 4)
            {
                tanks.MoveDown2(e.Graphics);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //k
            if (k == 1)
            {
                tanks.location.X += 10;
            }
            if (k == 2)
            {
                tanks.location.X -= 10;
            }
            if (k == 3)
            {
                tanks.location.Y -= 10;
            }
            if (k == 4)
            {
                tanks.location.Y += 10;
            }
            //s
            if (s == 1)
            {
                tanks.location2.X += 10;
            }
            if (s == 2)
            {
                tanks.location2.X -= 10;
            }
            if (s == 3)
            {
                tanks.location2.Y -= 10;
            }
            if (s == 4)
            {
                tanks.location2.Y += 10;
            }
            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //k
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
            //s
            if (e.KeyCode == Keys.D)
            {
                s = 1;
            }
            if (e.KeyCode == Keys.A)
            {
                s = 2;
            }
            if (e.KeyCode == Keys.W)
            {
                s = 3;
            }
            if (e.KeyCode == Keys.S)
            {
                s = 4;
            }
        }

    }
}
