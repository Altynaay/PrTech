using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;

namespace Tank
{
    public class TankGame
    {
        public Pen pen = new Pen(Color.Black);
        public Point location;
        public int length = 40;
        SolidBrush brushblack = new SolidBrush(Color.Black);
        public void MoveUp(Graphics g)
        {
            while (location.Y != 0)
            {
                g.Clear(Color.White);
                g.FillRectangle(brushblack, location.X + 30, location.Y + 30, length, length);
                g.FillRectangle(brushblack, location.X + 40, location.Y + 10, length / 2, length);
                location.Y--;
                Thread.Sleep(10);
            }
        }
        public void MoveDown(Graphics g)
        {
            while (location.Y != 390)
            {
                g.Clear(Color.White);
                g.FillRectangle(brushblack, location.X + 30, location.Y + 30, length, length);
                g.FillRectangle(brushblack, location.X + 40, location.Y + 50, length / 2, length);
                location.Y++;
                Thread.Sleep(10);
            }
        }
        public void MoveRight(Graphics g)
        {
            while (location.X != 865)
            {
                g.Clear(Color.White);
                g.FillRectangle(brushblack, location.X + 30, location.Y + 30, length, length);
                g.FillRectangle(brushblack, location.X + 50, location.Y + 40, length, length / 2);
                location.X++;
                Thread.Sleep(10);
            }
        }
        public void MoveLeft(Graphics g)
        {
            while (location.X != 0)
            {
                g.Clear(Color.White);
                g.FillRectangle(brushblack, location.X + 30, location.Y + 30, length, length);
                g.FillRectangle(brushblack, location.X + 10, location.Y + 40, length, length / 2);
                location.X--;
                Thread.Sleep(10);
            }
        }
        

    }
}
