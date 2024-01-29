using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musikkbibliotek
{
    internal class Casette : Album, IAlbum
    {


        private string _format = "Casette";

        public Casette(string format, string name, int releaseyear, string bandname, List<Song> songs) : base(name, releaseyear, bandname, songs)
        {
            _format = format;
        }

        public Casette()
        {

        }

        public override string GetFormat()
        {
            return _format;
        }
        
        public void PlayAlbum()
        {

        }
    }
}
