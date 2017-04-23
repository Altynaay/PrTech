using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Tank
{
    class Bullet
    {
        public Point lbulUp,lbulRight,lbulLeft,lbulDown;
        public Point lbulUp2, lbulRight2, lbulLeft2, lbulDown2;
        public Pen pen = new Pen(Color.Red);
        SolidBrush brushred = new SolidBrush(Color.Blue);

        public void BulUp(Graphics g)
        {
            g.FillEllipse(brushred,lbulUp.X, lbulUp.Y, 10, 10);
        }
        public void BulDown(Graphics g)
        {
            g.FillEllipse(brushred, lbulDown.X, lbulDown.Y, 10, 10);
        }
        public void BulLeft(Graphics g)
        {
            g.FillEllipse(brushred, lbulLeft.X, lbulLeft.Y, 10, 10);
        }
        public void BulRight(Graphics g)
        {
            g.FillEllipse(brushred, lbulRight.X, lbulRight.Y, 10, 10);
        }
        
        SolidBrush brushblue = new SolidBrush(Color.Red);
 
        public void BulUp2(Graphics g)
        {
            g.FillEllipse(brushblue, lbulUp2.X, lbulUp2.Y, 10, 10);
        }
        public void BulDown2(Graphics g)
        {
            g.FillEllipse(brushblue, lbulDown2.X, lbulDown2.Y, 10, 10);
        }
        public void BulLeft2(Graphics g)
        {
            g.FillEllipse(brushblue, lbulLeft2.X, lbulLeft2.Y, 10, 10);
        }
        public void BulRight2(Graphics g)
        {
            g.FillEllipse(brushblue, lbulRight2.X, lbulRight2.Y, 10, 10);
        }
    }
}
