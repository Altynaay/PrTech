using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Far
{
    class Program
    {
        static void ex1()
        {
            DirectoryInfo directory = new DirectoryInfo(@"G:/KBTU");
            FileInfo[] files = directory.GetFiles();
            DirectoryInfo[] directories = directory.GetDirectories();
            Console.WriteLine(directories.Length);
            Console.WriteLine(files.Length);
            Console.ReadKey();
        }
        static void ex2()
        {
            DirectoryInfo directory = new DirectoryInfo(@"G:/KBTU");
            FileInfo[] files = directory.GetFiles();
            DirectoryInfo[] directories = directory.GetDirectories();
            foreach (DirectoryInfo dInfo in directories)
            {
                Console.WriteLine(dInfo.Name);
            }
            foreach (FileInfo fil in files)
            {
                Console.WriteLine(fil.Name);
            }
            Console.ReadKey();
        }
        static void Show(DirectoryInfo directory, int cursor)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            int index = 0;
            foreach (FileSystemInfo finfo in directory.GetFileSystemInfos())
            {
                if (index == cursor)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                index++;
                if (finfo.GetType() == typeof(FileInfo))
                {
                    Console.Write("File:");
                }
                else
                    Console.Write("Directory:");
                Console.WriteLine(finfo.Name);
            }
        }
        static void Main(string[] args)
        {
            int cursor = 0;
            DirectoryInfo directory = new DirectoryInfo(@"G:\");
            while (true)
            {
                Console.Clear();
                Show(directory, cursor);
                ConsoleKeyInfo pressed = Console.ReadKey();
                if (pressed.Key == ConsoleKey.UpArrow)
                {
                    if (cursor > 0)
                    {
                        cursor--;
                    }
                }
                if (pressed.Key == ConsoleKey.DownArrow)
                {
                    if (cursor < directory.GetFileSystemInfos().Length - 1)
                    {
                        cursor++;
                    }
                }
                if (pressed.Key == ConsoleKey.Enter)
                {
                    FileSystemInfo file = directory.GetFileSystemInfos()[cursor];
                    if (file.GetType() == typeof(DirectoryInfo))
                    {
                        directory = new DirectoryInfo(file.FullName);
                    }
                    else
                    {
                        Console.Clear();
                        FileStream fie = new FileStream(file.FullName, FileMode.Open, FileAccess.Read);
                        StreamReader sr = new StreamReader(fie);
                        string s = sr.ReadToEnd();
                        Console.WriteLine(s);
                        sr.Close();
                        fie.Close();
                        Console.ReadKey();
                    }

                    /*if(cursor == FileSystemInfo){
                    FileSystemInfo file = directory.GetFileSystemInfos()[cursor];
                    directory = new DirectoryInfo(file.FullName);
                    }*/
                }
                if (pressed.Key == ConsoleKey.Backspace)
                {
                    try
                    {
                        directory = Directory.GetParent(directory.FullName);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error");
                    }
                    if (pressed.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
            }
        }
    }
}
