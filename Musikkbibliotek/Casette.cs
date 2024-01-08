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

        public Casette(string format)
        {
            _format = format;
        }

        public void PlayAlbum()
        {

        }
    }
}
