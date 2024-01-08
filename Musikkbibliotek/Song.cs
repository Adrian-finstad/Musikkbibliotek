using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musikkbibliotek
{
    internal class Song
    {
        private string Name { get; set; }
        private string BandName { get; set; }
        private int PlayCount { get; set; }


        public Song(string name, string bandname, int playcount)
        {
            Name = name;
            BandName = bandname;
            PlayCount = playcount;
        }

        public string GetSongName() {  return Name; }
        public int GetPlayCount() {  return PlayCount; }
        public string GetBandName() {  return BandName; }



    }

}
