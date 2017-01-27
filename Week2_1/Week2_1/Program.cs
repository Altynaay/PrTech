using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:/Users/Nurzhigit/Documents/Visual Studio 2013/Projects/Week2_1/Week2_1/test.txt");
            string line;
            int size = int.Parse(file.ReadLine());
            int[] arr = new int[size];
            int i =0,n =999999,x =0;
            while ((line = file.ReadLine()) != null)
            {
                arr[i] = int.Parse(line);
                i++;    
            }
            for (int j = 0; j < size; j++) {
                if (x <= arr[j])
                {
                    x = arr[j];
                }
                if (n >= arr[j])
                {
                    n = arr[j];
                }
                //Console.Write(arr[j]);
            }
            Console.WriteLine(x);
            Console.WriteLine(n);

                file.Close();
                Console.ReadKey();
        }
    }
}
