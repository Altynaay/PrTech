using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Week2_1
{
    class Program
    {
        static bool check(int x)
        {
            for (int i = 2; i <= x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader(@"C:/Users/Nurzhigit/Documents/Visual Studio 2013/Projects/Week2_1/Week2_1/test.txt");
            StreamWriter sw = new StreamWriter(@"C:/Users/Nurzhigit/Documents/Visual Studio 2013/Projects/Week2_1/Week2_1/output.txt");
            string line;
            int size = int.Parse(file.ReadLine());
            int[] arr = new int[size];
            int i = 0, n = 999999, x = 0;
            while ((line = file.ReadLine()) != null)
            {
                arr[i] = int.Parse(line);
                i++;
            }
            for (int j = 0; j < size; j++)
            {
                if (check(arr[j]) && x >= arr[j])
                {
                    x = arr[j];
                }
                //Console.Write(arr[j]);
            }
            file.Close();
            Console.ReadKey();
        }
    }
}
