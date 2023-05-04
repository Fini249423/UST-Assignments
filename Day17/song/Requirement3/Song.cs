using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Requirement3
{
    public class Song
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;

            }
        }
        private string _artist;
        public string Artist
        {
            get
            {
                return _artist;
            }
            set
            {
                _artist = value;

            }
        }
        private string _songType;
        public string SongType
        {
            get
            {
                return _songType;
            }
            set
            {
                _songType = value;

            }
        }
        private double _rating;
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                _rating = value;

            }
        }
        private int _numberOfDownloads;
        public int NumberOfDownloads
        {
            get
            {
                return _numberOfDownloads;
            }
            set
            {
                _numberOfDownloads = value;

            }
        }
        private DateTime _dateDownloaded;
        public DateTime DateDownloaded
        {
            get
            {
                return _dateDownloaded;
            }
            set
            {
                _dateDownloaded = value;

            }
        }
        public Song()
        {

        }
        public Song(string name, string artist, string songType, double rating, int numberOfDownloads, DateTime dateDownloaded)
        {
            _name = name;
            _artist = artist;
            _songType = songType;
            _rating = rating;
            _numberOfDownloads = numberOfDownloads;
            _dateDownloaded = dateDownloaded;         
        }
        public override string ToString()
        {
            return string.Format("{0}\t\t {1}\t\t  {2}\t\t  {3}\t\t  {4}\t\t  {5}\t", Name, Artist, SongType, Rating, NumberOfDownloads, DateDownloaded);

        }

    }
}
