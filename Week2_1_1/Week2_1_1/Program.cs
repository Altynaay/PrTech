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
        static void ex1()
        {
            DirectoryInfo directory = new DirectoryInfo(@"G:");
            //gettin files
            FileInfo[] files = directory.GetFiles();
            //getting directories
            DirectoryInfo[] directories = directory.GetDirectories();

            Console.WriteLine();
            Console.WriteLine("Files:");
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Directories:");
            foreach (DirectoryInfo directoryInfo in directories)
            {
                Console.WriteLine(directoryInfo.Name);
            }

            Console.ReadKey();
        }
        static void ex23()
        {
            DirectoryInfo directory = new DirectoryInfo(@"G:");
            //getting files
            FileInfo[] files = directory.GetFiles();
            //getting directories
            DirectoryInfo[] directories = directory.GetDirectories();
            Console.WriteLine("Files:");
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Directories:");
            foreach (DirectoryInfo dInfo in directories)
            {
                Console.WriteLine(dInfo.Name);
            }
            Console.ReadKey();

        }
        static void Fil()
        {
            DirectoryInfo directory = new DirectoryInfo(@"G:");
            FileInfo[] files = directory.GetFiles();
            DirectoryInfo[] directories = directory.GetDirectories();

            Console.WriteLine("Files:");
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Directories:");
            foreach (DirectoryInfo dInfo in directories)
            {
                Console.WriteLine(dInfo.Name);
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Fil();
        }
    }
}