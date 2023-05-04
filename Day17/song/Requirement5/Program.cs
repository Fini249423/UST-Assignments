using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> ls = new List<Song>();
            Console.WriteLine("Enter the number of songs");
            int n=int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                string[] s = Console.ReadLine().Split(',');
                
                DateTime date = DateTime.ParseExact(s[5],"dd-MM-yyyy",null);
                int noofdownloads = int.Parse(s[4]);

                Song s1=new Song(s[0], s[1], s[2], double.Parse(s[3]),noofdownloads,date);
                ls.Add(s1);

            }

            SortedDictionary<string,int>SortedDictionary = new SortedDictionary<string,int>();
            SortedDictionary = Song.CalculateTypeCount(ls);
            Console.WriteLine("{0} {1,15}", "SongType","Count");
            foreach(var item in SortedDictionary)
            {
                Console.WriteLine("{0}{1,15}", item.Key, item.Value);
            }
            

        }
    }
}
