using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement3
{
    class SongRepo
    {
        static List<Song> _songs = new List<Song>()
        {
            new Song("Shape of you","Ed Sheeran","pop",4.8,100000,DateTime.Parse("12-01-2018")),
            new Song("Perfect","Ed Sheeran","pop",4.8,100000,DateTime.Parse("12-01-2018")),
            new Song("Mercy","Shawn Mendes","Jazz",4.6,50000,DateTime.Parse("03-09-2016"))

        };

        public static List<Song>GetAllSongs()
        {
            return _songs;
        }

        
    }
}
