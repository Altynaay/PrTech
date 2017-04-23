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
        Bitmap bitmap;
        Bullet bullets = new Bullet();
        Graphics G;
        public int k = 1, s = 4, p = 1, t = 1;
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
            //k stage

            if (p == 2) bullets.BulRight(e.Graphics);
            if (p == 3) bullets.BulRight(e.Graphics);
            if (p == 4) bullets.BulRight(e.Graphics);
            if (p == 5) bullets.BulRight(e.Graphics);

            if (k == 1) tanks.MoveRight(e.Graphics);
            if (k == 2) tanks.MoveLeft(e.Graphics);
            if (k == 3) tanks.MoveUp(e.Graphics);
            if (k == 4) tanks.MoveDown(e.Graphics);
            //s stage

            if (s == 1) tanks.MoveRight2(e.Graphics);
            if (s == 2) tanks.MoveLeft2(e.Graphics);
            if (s == 3) tanks.MoveUp2(e.Graphics);
            if (s == 4) tanks.MoveDown2(e.Graphics);

            if (t == 2) bullets.BulRight2(e.Graphics);
            if (t == 3) bullets.BulRight2(e.Graphics);
            if (t == 4) bullets.BulRight2(e.Graphics);
            if (t == 5) bullets.BulRight2(e.Graphics);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //First K stage
            
            if (k == 1)
            {
                tanks.location.X += 10;
                if (tanks.location.X == 900)
                {
                    tanks.location.X = 0;
                }
            }
            if (k == 2)
            {
                tanks.location.X -= 10;
                if (tanks.location.X < 0)
                {
                    tanks.location.X = 900;
                }
            }
            if (k == 3)
            {
                tanks.location.Y -= 10;
                if (tanks.location.Y <= 0)
                {
                    tanks.location.Y = 450;
                }
            }
            if (k == 4)
            {
                tanks.location.Y += 10;
                if (tanks.location.Y >= 450)
                {
                    tanks.location.Y = 0;
                }
            }


            if (p == 2)
            {
                bullets.lbulRight.X += 20;
                if (tanks.location.X < bullets.lbulRight.X  && bullets.lbulRight.X < 1007)
                {
                    bullets.lbulRight.X += 20;
                }
                else
                {
                    bullets.lbulRight.X = tanks.location.X;
                    p = 1;
                }
            }
            if (p == 3)
            {
                bullets.lbulRight.X -= 20;
                if (tanks.location.X > bullets.lbulRight.X && bullets.lbulRight.X > 0)
                {
                    bullets.lbulRight.X -= 20;
                }
                else
                {
                    bullets.lbulRight.X = tanks.location.X;
                    p = 1;
                }

            }
            if (p == 4)
            {
                bullets.lbulRight.Y -= 20;
                if (tanks.location.Y > bullets.lbulRight.Y && bullets.lbulRight.Y > 0)
                {
                    bullets.lbulRight.Y -= 20;
                }
                else
                {
                    bullets.lbulRight.Y = tanks.location.Y;
                    p = 1;
                }
            }
            if (p == 5)
            {
                bullets.lbulRight.Y += 20;
                if (tanks.location.Y < bullets.lbulRight.Y && bullets.lbulRight.Y < 900)
                {
                    bullets.lbulRight.Y += 20;
                }
                else
                {
                    bullets.lbulRight.Y = tanks.location.Y;
                    p = 1;
                }
            }


            // Second S Stage 
            if (s == 1)
            {
                tanks.location2.X += 10;
                if (tanks.location2.X == 900)
                {
                    tanks.location2.X = 0;
                }
            }
            if (s == 2)
            {
                tanks.location2.X -= 10;
                if (tanks.location2.X < 0)
                {
                    tanks.location2.X = 900;
                }
            }
            if (s == 3)
            {
                tanks.location2.Y -= 10;
                if (tanks.location2.Y <= 0)
                {
                    tanks.location2.Y = 450;
                }
            }
            if (s == 4)
            {
                tanks.location2.Y += 10;
                if (tanks.location2.Y >= 450)
                {
                    tanks.location2.Y = 0;
                }
            }

             
            if (t == 2)
            {
                bullets.lbulRight2.X += 20;
                if (tanks.location2.X < bullets.lbulRight2.X && bullets.lbulRight2.X < 1007)
                {
                    bullets.lbulRight2.X += 20;
                }
                else
                {
                    bullets.lbulRight2.X = tanks.location2.X;
                    t = 1;
                }
            }
            if (t == 3)
            {
                bullets.lbulRight2.X -= 20;
                if (tanks.location2.X > bullets.lbulRight2.X && bullets.lbulRight2.X > 0)
                {
                    bullets.lbulRight2.X -= 20;
                }
                else
                {
                    bullets.lbulRight2.X = tanks.location2.X;
                    t = 1;
                }
            }
            if (t == 4)
            {
                bullets.lbulRight2.Y -= 20;
                if (tanks.location2.Y > bullets.lbulRight2.Y && bullets.lbulRight2.Y > 0)
                {
                    bullets.lbulRight2.Y -= 20;
                }
                else
                {
                    bullets.lbulRight2.Y = tanks.location2.Y;
                    t = 1;
                }
            }
            if (t == 5)
            {
                bullets.lbulRight2.Y += 20;
                if (tanks.location2.Y < bullets.lbulRight2.Y && bullets.lbulRight2.Y < 900)
                {
                    bullets.lbulRight2.Y += 20;
                }
                else
                {
                    bullets.lbulRight2.Y = tanks.location2.Y;
                    t = 1;
                }
            }
            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //First K STAGE
            if (e.KeyCode == Keys.Right) k = 1;
            if (e.KeyCode == Keys.Left) k = 2;
            if (e.KeyCode == Keys.Up) k = 3;
            if (e.KeyCode == Keys.Down) k = 4;
            if (e.KeyCode == Keys.Space && k == 1)
            {
                p = 2;
                bullets.lbulRight.X = tanks.location.X;
                bullets.lbulRight.Y = tanks.location.Y + 40;
            }
            if (e.KeyCode == Keys.Space && k == 2)
            {
                p = 3;
                bullets.lbulRight.X = tanks.location.X;
                bullets.lbulRight.Y = tanks.location.Y + 40;
            }
            if (e.KeyCode == Keys.Space && k == 3)
            {
                p = 4;
                bullets.lbulRight.Y = tanks.location.Y;
                bullets.lbulRight.X = tanks.location.X + 40;
            }
            if (e.KeyCode == Keys.Space && k == 4)
            {
                p = 5;
                bullets.lbulRight.Y = tanks.location.Y;
                bullets.lbulRight.X = tanks.location.X + 40;
            }

            //SECOND S STAGE
            if (e.KeyCode == Keys.D) s = 1;
            if (e.KeyCode == Keys.A) s = 2;
            if (e.KeyCode == Keys.W) s = 3;
            if (e.KeyCode == Keys.S) s = 4;


            if (e.KeyCode == Keys.Tab && s == 1)
            {
                t = 2;
                bullets.lbulRight2.X = tanks.location2.X + 55;
                bullets.lbulRight2.Y = tanks.location2.Y + 43;
            }
            if (e.KeyCode == Keys.Tab && s == 2)
            {
                t = 3;
                bullets.lbulRight2.X = tanks.location2.X;
                bullets.lbulRight2.Y = tanks.location2.Y + 43;
            }
            if (e.KeyCode == Keys.Tab && s == 3)
            {
                t = 4;
                bullets.lbulRight2.Y = tanks.location2.Y;
                bullets.lbulRight2.X = tanks.location2.X + 40; 
            }
            if (e.KeyCode == Keys.Tab && s == 4)
            {
                t = 5;
                bullets.lbulRight2.Y = tanks.location2.Y + 55;
                bullets.lbulRight2.X = tanks.location2.X + 40;
            }
            
        }
    }
}
