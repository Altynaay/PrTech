﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_number
{
    class Program
    {
        static bool check(int n)
        {
            for (int i = 2; i <= n; i++)// check number on is it Prime 
            {
                if (n % i == 0)
                {
                    return false;
                }
                else
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int[] arr = new int[s.Length];
            for (int i = 0; i < s.Length; i++)//
            {
                arr[i] = int.Parse(s[i]);//take numbers as integer

            }
                for (int i = 0; i < s.Length; i++)
                {
                    if (arr[i] == 1)
                    {
                        Console.WriteLine(1);
                    }
                    if (arr[i] == 2)
                    {
                        Console.WriteLine(2);
                    }

                    if (check(arr[i])) //check array numbers
                    {
                        Console.WriteLine(arr[i]);
                    }


                }
            Console.ReadKey();
        }
    }
}