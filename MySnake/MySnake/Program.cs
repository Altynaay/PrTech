using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace W5Snake
{
    class Program
    {
        public static int d = 2;

        static void Main(string[] args)
        {
            Thread t = new Thread(ThreadSnake);
            t.Start();
            Game.Init();

            while (!Game.GameOver)
            {
                Game.Draw();

                ConsoleKeyInfo pressed = Console.ReadKey();
                if (pressed.Key == ConsoleKey.UpArrow)
                    //Game.snake.Move(0, -1);
                    d = 1;
                if (pressed.Key == ConsoleKey.DownArrow)
                    //Game.snake.Move(0, 1);
                    d = 2;
                if (pressed.Key == ConsoleKey.LeftArrow)
                    d = 3;
                    //Game.snake.Move(-1, 0);
                if (pressed.Key == ConsoleKey.RightArrow)
                    d = 4;
                    //Game.snake.Move(1, 0);
               /* if (pressed.Key == ConsoleKey.F2)
                    Game.Save();
                if (pressed.Key == ConsoleKey.F3)
                    Game.Resume();*/
                if (pressed.Key == ConsoleKey.Escape)
                    Game.GameOver = true;
            }
        }
        public static void ThreadSnake()
        {
            while (!Game.GameOver)
            {
                Game.Draw();
                //Cnt();
                Thread.Sleep(300);
                switch (d)
                {
                    case 1:
                        Game.snake.Move(0, -1);
                        break;
                    case 2:
                        Game.snake.Move(0, 1);
                        break;
                    case 3:
                        Game.snake.Move(-1, 0);
                        break;
                    case 4:
                        Game.snake.Move(1, 0);
                        break;
                }

            }
        }
    }
}