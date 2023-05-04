using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement3
{
    class SongBO
    {
        private double rate;
        private DateTime date;

        public SongBO(List<Song>ls,string type)
        {
            Ls = ls;
            Type = type;
        }

        public SongBO(List<Song> ls, double rate)
        {
            Ls = ls;
            this.rate = rate;
        }

        public SongBO(List<Song> ls, DateTime date)
        {
            Ls = ls;
            this.date = date;
        }

        public List<Song> Ls { get; }
        public string Type { get; }
        public List<Song> FindSong(List<Song>SongList, string type)
        {
            List<Song> fs = new List<Song>();
            foreach (Song s in SongList)
            {
                if(s.SongType == type)
                {
                    fs.Add(s);
                }
            }
            return fs;
            
        }
        public List<Song>FindSong(List<Song> SongList, DateTime dateCreated)
        {
            List<Song> fs=new List<Song>();
            foreach(Song s in SongList)
            {
                if (s.DateDownloaded ==  dateCreated)
                {
                    fs.Add(s);
                }
            }
            return fs;
        }
        public List<Song> FindSong(List<Song> SongList, double rating)

        {
            List<Song> fs = new List<Song>();
            foreach (Song s in SongList)
            {
                if (s.Rating == rating)
                {
                    fs.Add(s);
                }
            }
            return fs;
        }









    }
}
