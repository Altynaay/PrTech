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
        public Point ellip,ellip2,ellip3,ellip4;
        public Point star,star2,star3,star4;
        public Point locationbul;
        public int length;
        public int radius;
        public int gunW, gunH;
        public GraphicsPath bullet1 = new GraphicsPath();
        public GraphicsPath bullet2 = new GraphicsPath();
        public int x, y;
        public Point raketa;
        Pen pen = new Pen(Color.Black);
        Color customColor = Color.FromArgb(50, Color.Black);
        Rectangle rect = new Rectangle(0, 0, 900, 800);
        Rectangle leftrect = new Rectangle(0, 0, 10, 800);
        Rectangle uprect = new Rectangle(0, 0, 800, 10);
        Rectangle rightrect = new Rectangle(775, 0, 10, 800);
        Rectangle downrect = new Rectangle(0, 437, 800, 10);
        SolidBrush brushwhite = new SolidBrush(Color.White);
        SolidBrush brushblue = new SolidBrush(Color.Blue);
        SolidBrush brushblack = new SolidBrush(Color.Black);
        SolidBrush brushyellow = new SolidBrush(Color.Yellow);
        SolidBrush brushgreen = new SolidBrush(Color.Green);
        SolidBrush brushred = new SolidBrush(Color.Red);
        
        public void Ellipse(Graphics g)
        {
            ellip.X = 50;   ellip.Y = 50;
            ellip2.X = 50;  ellip2.Y = 50;
            ellip3.X = 50;  ellip3.Y = 50;
            ellip4.X = 50;  ellip4.X = 50;
            length = 30;
            //frame of the asteroid game SPACESHIP
            g.FillRectangle(brushblue, rect);
            // Frame of the asteroid game
            g.FillRectangle(brushblack, uprect);
            g.FillRectangle(brushblack, leftrect);
            g.FillRectangle(brushblack, rightrect);
            g.FillRectangle(brushblack, downrect);
            //Stars of the game
            g.FillEllipse(brushwhite, ellip.X, ellip.Y, length, length);
            g.FillEllipse(brushwhite, ellip.X + 200, ellip.Y - 30, length, length);
            g.FillEllipse(brushwhite, ellip2.X + 5, ellip2.Y + 250, length, length);
            g.FillEllipse(brushwhite, ellip2.X + 200, ellip2.Y + 220, length, length);
            g.FillEllipse(brushwhite, ellip3.X + 450, ellip3.Y + 10, length, length);
            g.FillEllipse(brushwhite, ellip3.X + 680, ellip3.Y + 80, length, length);
            g.FillEllipse(brushwhite, ellip4.X + 680, ellip4.Y + 270, length, length);
            g.FillEllipse(brushwhite, ellip4.X + 600, ellip4.Y + 150, length, length);
        }
        public void Polygon(Graphics g)
        {
            //Gun
            raketa.X = 420;
            raketa.Y = 170;
            Point point1 = new Point(raketa.X, raketa.Y - 30);//y = 140
            Point point2 = new Point(raketa.X + 30, raketa.Y);//y = 170
            Point point3 = new Point(raketa.X + 30, raketa.Y + 30);//y = 200
            Point point4 = new Point(raketa.X, raketa.Y + 60);//y = 230
            Point point5 = new Point(raketa.X - 30, raketa.Y + 30);//y = 200
            Point point6 = new Point(raketa.X - 30, raketa.Y);//y = 170
            Point point7 = new Point(raketa.X, raketa.Y - 30);//y = 140
            //Point point7 = new Point();
            Point[] curvePoints = { point1, point2, point3, point4, point5, point6, point7};
            g.FillPolygon(brushyellow, curvePoints);
            
        }
        public void strelka(Graphics g)
        {
            raketa.X = 420;
            raketa.Y = 190;
            Point[] strelkapoints = 
            {
                new Point(raketa.X - 20, raketa.Y - 10),//x = 400 ; y = 180  
                new Point(raketa.X, raketa.Y - 30),//x = 420 ; y = 160
                new Point(raketa.X + 20, raketa.Y - 10),//x = 440 ; y = 180
                new Point(raketa.X + 6, raketa.Y - 10),//x = 426 ; y = 180
                new Point(raketa.X + 6, raketa.Y + 15),//x = 426 ; y = 205
                new Point(raketa.X - 6, raketa.Y + 15),//x = 414 ; y = 205
                new Point(raketa.X - 6, raketa.Y - 10),//x = 414 ; y = 180
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
            star.X = 200;//200
            star.Y = 260;
            //Asteroids RED ZVEZDO4ka
            Point[] points1 =
             {
                new Point(star.X,star.Y - 30),
                new Point(star.X + 30,star.Y + 15),
                new Point(star.X - 30,star.Y + 15)
            };
            Point[] points2 =
            {
                new Point(star.X - 30,star.Y - 15),
                new Point(star.X + 30,star.Y - 15),
                new Point(star.X,star.Y + 30)
            };
            star2.X = 150;
            star2.Y = 150;
            Point[] points3 =
             {
                new Point(star2.X,star2.Y - 30),
                new Point(star2.X + 30,star2.Y + 15),
                new Point(star2.X - 30,star2.Y + 15)
            };
            Point[] points4 =
            {
                new Point(star2.X - 30,star2.Y - 15),
                new Point(star2.X + 30,star2.Y - 15),
                new Point(star2.X,star2.Y + 30)
            };
            star3.X = 600;
            star3.Y = 150;
            Point[] points5 =
             {
                new Point(star3.X,star3.Y - 30),
                new Point(star3.X + 30,star3.Y + 15),
                new Point(star3.X - 30,star3.Y + 15)
            };
            Point[] points6 =
            {
                new Point(star3.X - 30,star3.Y - 15),
                new Point(star3.X + 30,star3.Y - 15),
                new Point(star3.X,star3.Y + 30)
            };

            star4.X = 550;
            star4.Y = 300;
            Point[] points7 =
             {
                new Point(star4.X,star4.Y - 30),
                new Point(star4.X + 30,star4.Y + 15),
                new Point(star4.X - 30,star4.Y + 15)
            };
            Point[] points8 =
            {
                new Point(star4.X - 30,star4.Y - 15),
                new Point(star4.X + 30,star4.Y - 15),
                new Point(star4.X,star4.Y + 30)
            };
            g.FillPolygon(brushred, points1);     g.FillPolygon(brushred, points2);
            g.FillPolygon(brushred, points3);     g.FillPolygon(brushred, points4);
            g.FillPolygon(brushred, points5);     g.FillPolygon(brushred, points6);
            g.FillPolygon(brushred, points7);     g.FillPolygon(brushred, points8);
        }
    }
}
