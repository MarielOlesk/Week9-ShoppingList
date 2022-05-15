using System;
using System.IO;

namespace DirectoriesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"D:\visual_studio_failid";
            Console.WriteLine("Enter directory name:");
            string newDirectorty = Console.ReadLine();
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();

            if (Directory.Exists($"{rootDirectory}\\{newDirectorty}"))
            {
                Console.WriteLine($"Directory {rootDirectory}\\{newDirectorty} already exists");
            }
            else
            {
                Directory.CreateDirectory($@"{rootDirectory}\{newDirectorty}");
            }

            File.Create($"{rootDirectory}\\{newDirectorty}\\{fileName}");
        }
    }
}
