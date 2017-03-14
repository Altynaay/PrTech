using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Example2
{
    class Program
    {

        static void calculator()
        {

            int p, r, k, n, x;
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            //string[] s = Console.ReadLine().Split(); // cin numbers
            p = s.Length + 1;
            r = t.Length + 1;
            if (p > r)
            {
                n = p;
            }
            else
            {
                n = r;
            }
            //int[] arr = new int[size];
            int[] a = new int[n];
            int[] b = new int[n];
            int[] c = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = 0;
                b[i] = 0;
            }
            k = n - 1;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                a[k] = s[i] - '0';
                k--;
            }
            k = n - 1;
            for (int i = t.Length - 1; i >= 0; i--)
            {
                b[k] = t[i] - '0';
                k--;
            }
            x = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                c[i] = (a[i] + b[i] + x) % 10;
                x = (a[i] + b[i] + x) / 10;
            }
            Console.WriteLine();
            int l;
            if (c[0] > 0)
            {
                l = 0;
            }
            else
                l = 1;
            Console.WriteLine("Result:");
            for (int i = l; i < n; i++)
            {
                Console.Write(c[i]);
            }
            public static Complex operator +(Complex c1, Complex c2)
            {
            Complex c = new Complex(c1.x + c2.x, c1.y + c2.y);
            return c;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            calculator();
        }
    }
}