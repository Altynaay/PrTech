using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace W5Snake
{
    [Serializable]
    class Game
    {
        public static bool GameOver = false;
        public static Snake snake = new Snake();
        public static Wall wall = new Wall();
        public static Food food = new Food();
        //public static int d = 4;
        public static void Init()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.CursorVisible = false;
            Console.SetWindowSize(80, 40);
        }
        /*public void ThreadSnake()
        {
            while (!GameOver)
            {
                Draw();
                //Cnt();
                Thread.Sleep(300);
                switch(d){
                    case 1:
                        snake.Move(0,-1);
                        break;
                    case 2:
                        snake.Move(0,1);
                        break;
                    case 3:
                        snake.Move(-1,0);
                        break;
                    case 4:
                        snake.Move(1,0);
                        break;
                }

            }
        }*/

        public static void Draw()
        {
            
            snake.Draw();
            wall.Draw();
            food.Draw();
        }

        public void Save()
        {
            Type t = this.GetType();
            FileStream fs = new FileStream(String.Format("{0}.dat", t.Name), FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();
            // serialize all objects
        }

        public void Resume()
        {
            Console.Clear();
            Type t = this.GetType();
            FileStream fs = new FileStream(String.Format("{0}.dat", t.Name), FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            if (t == typeof(Wall))
                Game.wall = bf.Deserialize(fs) as Wall;
            if (t == typeof(Snake))
                Game.snake = bf.Deserialize(fs) as Snake;
            if (t == typeof(Food))
                Game.food = bf.Deserialize(fs) as Food;
            // deserialize all objects
        }
    }
}