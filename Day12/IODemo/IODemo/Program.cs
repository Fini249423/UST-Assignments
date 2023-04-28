using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Directory Info *****\n");
            //DriveInfo[] myDrives = DriveInfo.GetDrives();


            DirectoryInfo dir = new DirectoryInfo(@"D:\Ust\Day12");

            Console.WriteLine("FullName: {0}", dir.FullName);

            Console.WriteLine("Name: {0}", dir.Name);

            Console.WriteLine("Parent: {0}", dir.Parent);

            Console.WriteLine("Creation: {0}", dir.CreationTime);

            Console.WriteLine("Attributes: {0}", dir.Attributes);

            Console.WriteLine("Root: {0}", dir.Root);

            Console.WriteLine("**************************\n");

            string path = @"D:\Ust\Day12\FileDemo\sample.txt";
            FileInfo fileInfo = new FileInfo(path);
            fileInfo.Create();
            {
                Console.WriteLine("File has been created");
            }
            Console.ReadKey();

        }
    }
}
