using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Musikkbibliotek
{
    internal class Album
    {
        private string Name {  get; set; }
        private int ReleaseYear { get; set; }
        private string BandName { get; set; }
        private List<Song> Songs { get; set; }

        public Album() { }

        public Album(string name, int releaseyear, string bandname, List<Song> songs)
        {
            Name = name;
            ReleaseYear = releaseyear;
            BandName = bandname;
            Songs = songs;
        }


        public string GetAlbumName()
        {
            return Name;
        }

        public int GetReleaseYear() 
        {
            return ReleaseYear; 
        }
        public string GetBandName() 
        {
            return BandName; 
        }

        public void SetNameOfNewAlbum()
        {
            Console.WriteLine("Please enter the name of the album you wish to add.");
            Name = Console.ReadLine();
        }
        public void SetReleaseYearOfNewAlbum()
        {
            Console.WriteLine("Please type in the releaseyear of the album");
            ReleaseYear = int.Parse(Console.ReadLine());
            
        }

        public void SetBandNameOfNewAlbum()
        {
            Console.WriteLine("Please enter the name of the band.");
            BandName = Console.ReadLine();
        }

    }
}
