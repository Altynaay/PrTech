﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;


namespace Operators
{
    class Program
    {
        static void time()
        {
            int x = 35, y = 10;
            Console.SetCursorPosition(x, y);
            while (true)
            {
                Console.Clear();
                for (int i = 1; i <= 12; i++)
                {
                    if (i <= 3)
                    {
                        x++;
                        y++;
                    }
                    if (i > 3 && i <= 6)
                    {
                        x--;
                        y++;
                    }
                    if (i > 6 && i <= 9)
                    {
                        x--;
                        y--;
                    }
                    if (i > 9 && i <= 12)
                    {
                        x++;
                        y--;
                    }
                    Console.SetCursorPosition(x, y);
                    Console.Write(" "+i);
                    Thread.Sleep(1000);

                }
            }
        }
        static void TT()
        {
            int j = 0, k = 1,h = 1;
            int[] p = new int[61];
            for (int i = 1; i < 61; i++)
            {
                p[i] = i;
            }
            while (true)
            {
                Console.Clear();
                j++;
                if (j == 60)
                {
                    k++;
                    Console.Clear();
                }
                if (k == 60)
                {
                    h++;
                    Console.Clear();
                }
                Console.Write(h + " ");
                Console.Write(k + " ");
                for (int i = 1; i <= 60; i++)
                {
                    if (p[j] == i + 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(p[i] + "   ");
                    }
                }
                Thread.Sleep(1);
                k %= 60;
                j %= 60;
            }
        }
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Thread t = new Thread(time);
            t.Start();
        }
    }
}