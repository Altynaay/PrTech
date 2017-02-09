using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader(@"G:\KBTU\2semestr\PT\number.txt");
            string l;
            string s = file.ReadLine();
            string[] p = s.Split();
            int sz = p.Length;
            int [] arr =new int [sz];
            for (int i = 0; i < sz; i++)
            {
                arr[i] = int.Parse(p[i]);
            }
            int n = arr[0];
            int x = arr[0];
            for (int j = 0; j < sz; j++)
            {
                if (arr[j] > n)
                {
                    n = arr[j];
                }
                if (arr[j] < x)
                {
                    x = arr[j];
                }
            }
            Console.WriteLine(x);
            Console.WriteLine(n);
            Console.ReadKey();

            file.Close();

        }
    }
}
