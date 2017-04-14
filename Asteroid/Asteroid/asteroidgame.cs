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
        public Point ellip,ellip2,ellip3,ellip4;
        public Point star;
        public Point star2,star3,star4;
        public Point locationbul;
        public int length;
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

            length = 30;
            x = 50; y = 50;
            //frame of the asteroid game SPACESHIP
            g.FillRectangle(brushblue, rect);
            // Frame of the asteroid game
            g.FillRectangle(brushblack, uprect);
            g.FillRectangle(brushblack, leftrect);
            g.FillRectangle(brushblack, rightrect);
            g.FillRectangle(brushblack, downrect);
            //Stars of the game
            g.FillEllipse(brushwhite, ellip.X + 50, ellip.Y + 100, length, length);
            g.FillEllipse(brushwhite, ellip.X + 250, ellip.Y + 20, length, length);
            g.FillEllipse(brushwhite, ellip2.X + 55, ellip2.Y + 300, length, length);
            g.FillEllipse(brushwhite, ellip2.X + 250, ellip2.Y + 270, length, length);
            g.FillEllipse(brushwhite, ellip3.X + 500, ellip3.Y + 60, length, length);
            g.FillEllipse(brushwhite, ellip3.X + 730, ellip3.Y + 130, length, length);
            g.FillEllipse(brushwhite, ellip4.X + 730, ellip4.Y + 320, length, length);
            g.FillEllipse(brushwhite, ellip4.X + 650, ellip4.Y + 200, length, length);
        }
        public void Polygon(Graphics g)
        {
            //Gun
            //raketa.X = 420;
            //raketa.Y = 170;
            Point point1 = new Point(raketa.X + 420, raketa.Y + 140);// y = 140
            Point point2 = new Point(raketa.X + 450, raketa.Y + 170);//y = 170
            Point point3 = new Point(raketa.X + 450, raketa.Y + 200);//y = 200
            Point point4 = new Point(raketa.X + 420, raketa.Y + 230);//y = 230
            Point point5 = new Point(raketa.X + 390, raketa.Y + 200);//y = 200
            Point point6 = new Point(raketa.X + 390, raketa.Y + 170);//y = 170
            Point point7 = new Point(raketa.X + 420, raketa.Y + 140);//y = 140
            //Point point7 = new Point();
            Point[] curvePoints = { point1, point2, point3, point4, point5, point6, point7};
            g.FillPolygon(brushyellow, curvePoints);
            
        }
        public void strelka(Graphics g)
        {
            //raketa.X = 420;
            //raketa.Y = 190;
            Point[] strelkapoints = 
            {
                new Point(raketa.X + 400, raketa.Y + 180),//x = 400 ; y = 180  
                new Point(raketa.X + 420, raketa.Y + 160),//x = 420 ; y = 160
                new Point(raketa.X + 440, raketa.Y + 180),//x = 440 ; y = 180
                new Point(raketa.X + 426, raketa.Y + 180),//x = 426 ; y = 180
                new Point(raketa.X + 426, raketa.Y + 205),//x = 426 ; y = 205
                new Point(raketa.X + 414, raketa.Y + 205),//x = 414 ; y = 205
                new Point(raketa.X + 414, raketa.Y + 180),//x = 414 ; y = 180
            };
            //strelka
            g.FillPolygon(brushgreen, strelkapoints);
        }
        public void Bullet(Graphics g)
        {
            //locationbul.X = 430;
            //locationbul.Y = 100;
            g.FillEllipse(brushgreen, locationbul.X + 430, locationbul.Y + 100, 10, 30);// x = 430  y = 100
            g.FillEllipse(brushgreen, locationbul.X + 420, locationbul.Y + 110, 30, 10);// x = 420  y = 110
        }
        public void Asters(Graphics g)
        {
           // star.X = 200;//200
           // star.Y = 260;
            //Asteroids RED ZVEZDO4ka
            Point[] points1 =
             {
                new Point(star.X + 200,star.Y + 230),
                new Point(star.X + 230,star.Y + 275),
                new Point(star.X + 170,star.Y + 275)
            };
            Point[] points2 =
            {
                new Point(star.X + 170,star.Y + 245),
                new Point(star.X + 230,star.Y + 245),
                new Point(star.X + 200,star.Y + 290)
            };
            //star2.X = 150;
            //star2.Y = 150;
            Point[] points3 =
             {
                new Point(star2.X + 150, star2.Y + 120),
                new Point(star2.X + 180,star2.Y + 165),
                new Point(star2.X + 120,star2.Y + 165)
            };
            Point[] points4 =
            {
                new Point(star2.X + 120,star2.Y + 135),
                new Point(star2.X + 180,star2.Y + 135),
                new Point(star2.X + 150,star2.Y + 180)
            };
            //star3.X = 600;
            //star3.Y = 150;
            Point[] points5 =
             {
                new Point(star3.X + 600,star3.Y + 120),
                new Point(star3.X + 630,star3.Y + 165),
                new Point(star3.X + 570,star3.Y + 165)
            };
            Point[] points6 =
            {
                new Point(star3.X +570,star3.Y + 135),
                new Point(star3.X + 630,star3.Y + 135),
                new Point(star3.X + 600,star3.Y + 180)
            };

           // star4.X = 550;
           // star4.Y = 300;
            Point[] points7 =
             {
                new Point(star4.X + 550,star4.Y + 270),
                new Point(star4.X + 580,star4.Y + 315),
                new Point(star4.X + 520,star4.Y + 315)
            };

            Point[] points8 =
            {
                new Point(star4.X + 520,star4.Y + 285),
                new Point(star4.X + 580,star4.Y + 285),
                new Point(star4.X + 550,star4.Y + 330)
            };

            g.FillPolygon(brushred, points1);     g.FillPolygon(brushred, points2);
            g.FillPolygon(brushred, points3);     g.FillPolygon(brushred, points4);
            g.FillPolygon(brushred, points5);     g.FillPolygon(brushred, points6);
            g.FillPolygon(brushred, points7);     g.FillPolygon(brushred, points8);
        }
    }
}
