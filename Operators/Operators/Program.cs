using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        class Complex
        {
            public int x, y;
            public Complex(int x,int y) //constructor that initializes info
            {
                this.x = x;
                this.y = y;
            }
            static int gcd(int x, int y)
            {
                if (x == 0)
                    return y;
                return gcd(y % x, x);
            }
            public override string ToString()
            {
                return this.x/gcd(this.x,this.y) + "/" + this.y/gcd(this.x, this.y);
            }
            public static Complex operator +(Complex x, Complex y)
            {
                Complex c = new Complex (x.x*y.y + y.x*x.y, x.y*y.y);
                return c;
            }
            public static Complex operator -(Complex x, Complex y)
            {
                Complex c = new Complex(x.x * y.y - y.x * x.y, x.y * y.y);
                return c;
            }
            public static Complex operator *(Complex x, Complex y)
            {
                Complex c = new Complex(x.x * y.x, x.y * y.y);
                return c;
            }
            public static Complex operator /(Complex x, Complex y)
            {
                Complex c = new Complex(x.x * y.y, y.x * x.y);
                return c;
            }
        }
        static void Main(string[] args)
        {
            Complex a = new Complex(1, 2);
            Complex b = new Complex(3, 4);

            Complex sum = a + b;
            Complex sub = a - b;
            Complex mult = a * b;
            Complex div = a / b;
            Console.WriteLine("result sum " + sum);
            Console.WriteLine("result sub " + sub);
            Console.WriteLine("result mult " + mult);
            Console.WriteLine("result div " + div);
            Console.ReadKey();
        }
    }
}
