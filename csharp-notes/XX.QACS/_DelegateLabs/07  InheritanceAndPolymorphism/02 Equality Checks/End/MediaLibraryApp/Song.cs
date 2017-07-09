using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibraryApp
{
    public class Song : MediaItem
    {

        public Song(string title, string artist, string imageLocation, TimeSpan duration)
            : base(title, artist, imageLocation, duration) { }

        protected override string MediaName
        {
            get { return "Song"; }
        }
        public override string MainPersonRole
        {
            get { return "Artist"; }
        }

    }
}
