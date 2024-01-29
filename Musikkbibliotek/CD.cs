using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musikkbibliotek
{
    internal class CD : Album, IAlbum
    {

        private string _format = "CD";
        public CD(string format, string name, int releaseyear, string bandname, List<Song> songs) : base(name, releaseyear, bandname, songs)
        {
            _format = format;
        }
        public CD()
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
