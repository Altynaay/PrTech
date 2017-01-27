using System;
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
            for (int i = 2; i <= n; i++)
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
            int c = int.Parse(Console.ReadLine());
            int  [] arr = new int [c];
            for (int i = 0; i < c; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
              //  Console.WriteLine(b);
              
            }

            for (int i = 0; i < c; i++)
            {
                if (check(arr[i]))
                {
                   Console.WriteLine(arr[i]);
                }
                
              
            }
            Console.ReadKey();
        }
    }
}
