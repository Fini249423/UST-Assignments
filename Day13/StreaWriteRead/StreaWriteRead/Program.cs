using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreaWriteRead
{
    internal class Program
    {
        static string file = @"D:\Ust\Day13";  //add the path
        static void Main(string[] args)
        {
            Write();
            Read();

        }
        static void Write()
        {
            StreamWriter fileStream = new StreamWriter(file);
            fileStream.WriteLine("What is this life if,full of care,");
            fileStream.WriteLine("We have no time to stand and stare");
            fileStream.Close();

        }
        static void Read()
        {
            StreamReader filestream= new StreamReader(file);
            string s = null;
            while((s=filestream.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            filestream.Close();
        }
    }
}
