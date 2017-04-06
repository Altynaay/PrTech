using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Asteroid
{
    class asteroidgame
    {
        public Point location;
        public Point locationbul;
        public int length;
        public int radius;
        public int gunW, gunH;
        public GraphicsPath bullet1 = new GraphicsPath();
        public GraphicsPath bullet2 = new GraphicsPath();
        public int x, y;
        
        Pen pen = new Pen(Color.Black);
        Color customColor = Color.FromArgb(50, Color.Black);
        SolidBrush brush = new SolidBrush(Color.White);
        Rectangle rect = new Rectangle(0, 0, 900, 800);
        Rectangle leftrect = new Rectangle(0, 0, 10, 800);
        Rectangle uprect = new Rectangle(0, 0, 800, 10);
        Rectangle rightrect = new Rectangle(775, 0, 10, 800);
        Rectangle downrect = new Rectangle(0, 437, 800, 10);
        SolidBrush brushblue = new SolidBrush(Color.Blue);
        SolidBrush brushblack = new SolidBrush(Color.Black);
        SolidBrush brushyellow = new SolidBrush(Color.Yellow);
        SolidBrush brushgreen = new SolidBrush(Color.Green);
        SolidBrush brushred = new SolidBrush(Color.Red);
        
        public void Ellipse(Graphics g)
        {
            location.X = 50;
            location.Y = 50;
            length = 30;
            //frame of the asteroid game SPACESHIP
            g.FillRectangle(brushblue, rect);
            // Frame of the asteroid game
            g.FillRectangle(brushblack, uprect);
            g.FillRectangle(brushblack, leftrect);
            g.FillRectangle(brushblack, rightrect);
            g.FillRectangle(brushblack, downrect);
            //Stars of the game
            g.FillEllipse(brush, location.X, location.Y, length, length);
            g.FillEllipse(brush, location.X + 200, location.Y - 30, length, length);
            g.FillEllipse(brush, location.X + 5, location.Y + 250, length, length);
            g.FillEllipse(brush, location.X + 200, location.Y + 220, length, length);
            g.FillEllipse(brush, location.X + 450, location.Y + 10, length, length);
            g.FillEllipse(brush, location.X + 680, location.Y + 80, length, length);
            g.FillEllipse(brush, location.X + 680, location.Y + 270, length, length);
            g.FillEllipse(brush, location.X + 600, location.Y + 150, length, length);
        }
        public void Polygon(Graphics g)
        {
            //Gun
            Point point1 = new Point(420, 140);
            Point point2 = new Point(450, 170);
            Point point3 = new Point(450, 200);
            Point point4 = new Point(420, 230);
            Point point5 = new Point(390, 200);
            Point point6 = new Point(390, 170);
            Point point7 = new Point(420, 140);
            //Point point7 = new Point();
            Point[] curvePoints = { point1, point2, point3, point4, point5, point6, point7};
            g.FillPolygon(brushyellow, curvePoints);
            
        }
        public void strelka(Graphics g)
        {
            x = 420;
            y = 190;
            Point[] strelkapoints = 
            {
                new Point(x - 20, y - 10),
                new Point(x, y - 30),
                new Point(x + 20, y - 10),
                new Point(x + 6, y - 10),
                new Point(x + 6, y + 15),
                new Point(x - 6, y + 15),
                new Point(x - 6, y - 10),
            };
            //strelka
            g.FillPolygon(brushgreen, strelkapoints);
        }
        public void Bullet(Graphics g)
        {
            locationbul.X = 430;
            locationbul.Y = 100;
            g.FillEllipse(brushgreen, locationbul.X, locationbul.Y, 10, 30);// x = 430  y = 100
            g.FillEllipse(brushgreen, locationbul.X - 10, locationbul.Y + 10, 30, 10);// x = 420  y = 110
        }
        public void Asters(Graphics g)
        {
            x = 200;
            y = 260;
            Point[] points1 =
             {
                new Point(x,y - 30),
                new Point(x + 30,y + 15),
                new Point(x - 30,y + 15)
            };
            Point[] points2 =
            {
                new Point(x - 30,y - 15),
                new Point(x + 30,y - 15),
                new Point(x,y + 30)
            };
            x = 150;
            y = 150;
            Point[] points3 =
             {
                new Point(x,y - 30),
                new Point(x + 30,y + 15),
                new Point(x - 30,y + 15)
            };
            Point[] points4 =
            {
                new Point(x - 30,y - 15),
                new Point(x + 30,y - 15),
                new Point(x,y + 30)
            };
            x = 600;
            y = 150;
            Point[] points5 =
             {
                new Point(x,y - 30),
                new Point(x + 30,y + 15),
                new Point(x - 30,y + 15)
            };
            Point[] points6 =
            {
                new Point(x - 30,y - 15),
                new Point(x + 30,y - 15),
                new Point(x,y + 30)
            };

            x = 550;
            y = 300;
            Point[] points7 =
             {
                new Point(x,y - 30),
                new Point(x + 30,y + 15),
                new Point(x - 30,y + 15)
            };
            Point[] points8 =
            {
                new Point(x - 30,y - 15),
                new Point(x + 30,y - 15),
                new Point(x,y + 30)
            };
            g.FillPolygon(brushred, points1);     g.FillPolygon(brushred, points2);
            g.FillPolygon(brushred, points3);     g.FillPolygon(brushred, points4);
            g.FillPolygon(brushred, points5);     g.FillPolygon(brushred, points6);
            g.FillPolygon(brushred, points7);     g.FillPolygon(brushred, points8);
        }
    }
}
