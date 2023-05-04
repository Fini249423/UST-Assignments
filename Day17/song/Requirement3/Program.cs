using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement3
{
    class Program
    {
        private static string dateCreated;

        static void Main(string[] args)
        {
            Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15}","Name", "Artist"," SongType", "Rating"," No.Of Downloads"," Date of Download");
            List<Song>ls=SongRepo.GetAllSongs();
            foreach (Song s in ls)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Enter the type");
            string Type=Console.ReadLine();

            SongBO s1=new SongBO(ls,Type);
            List<Song> songType=s1.FindSong(ls,Type);
            Console.WriteLine("SongName\t");
            foreach(Song s in songType)
            {
                Console.WriteLine(s.Name+"\t");
                Console.WriteLine(s.SongType);
            }


            Console.WriteLine("Enter the date");
            DateTime date = DateTime.Parse(Console.ReadLine());

            SongBO s2 = new SongBO(ls, date);
            List<Song> songdate = s2.FindSong(ls, Type);
            Console.WriteLine("SongName\t");
            foreach (Song s in songdate)
            {
                Console.WriteLine(s.Name + "\t");
                Console.WriteLine(s.DateDownloaded);
            }


            Console.WriteLine("Enter the Rating");
            double rate = double.Parse(Console.ReadLine());

            SongBO s3 = new SongBO(ls, rate);
            List<Song> songrating= s3.FindSong(ls, Type);
            Console.WriteLine("SongName\t");
            foreach (Song s in songrating)
            {
                Console.WriteLine(s.Name + "\t");
                Console.WriteLine(s.DateDownloaded);
            }



        }
    }
}
