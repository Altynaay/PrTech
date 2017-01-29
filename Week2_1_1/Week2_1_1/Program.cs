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
        
        static void Fil()
        {
            DirectoryInfo directory = new DirectoryInfo(@"G:");// get information from G: disk
            FileInfo[] files = directory.GetFiles();
            DirectoryInfo[] directories = directory.GetDirectories();

            Console.WriteLine("Files:");
            foreach (FileInfo file in files)//cycle which write files names
            {
                Console.WriteLine(file.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Directories:");
            foreach (DirectoryInfo dInfo in directories)//cycle which write directories names
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