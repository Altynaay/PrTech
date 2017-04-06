using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Asteroid
{
    class Bullet
    {
        public GraphicsPath path1 = new GraphicsPath();
        public GraphicsPath path2 = new GraphicsPath();
        Pen pen = new Pen(Color.Green);
        
        public Bullet(int x,int y)
        {
            path1.AddEllipse(x-5, y-13, 10, 26);
            path2.AddEllipse(x-13, y-5, 26, 10);
        }
    }
}
