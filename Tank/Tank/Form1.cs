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
/*using System.Drawing.Bitmap;
using System.Drawing.Graphics;
using System.Drawing.Image;*/

namespace Tank
{
    public partial class Form1 : Form
    {
        TankGame tanks = new TankGame();
        Graphics gpic;
        Bitmap bitmap;
        Graphics bitG;
        KeyEventArgs keypressed;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            tanks.MoveDown(e.Graphics);
            //tanks.MoveUp(e.Graphics);
            //tanks.MoveRight(e.Graphics);
            //tanks.MoveLeft(e.Graphics);
        }
        private void DownKey(object sender, KeyEventArgs g, PaintEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

    }
}
