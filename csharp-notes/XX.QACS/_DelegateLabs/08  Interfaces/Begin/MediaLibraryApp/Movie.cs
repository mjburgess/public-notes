using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibraryApp
{
    public class Movie : MediaItem
    {

        public Movie(string title, string director, string imageLocation, TimeSpan duration)
            : base(title, director, imageLocation, duration) { }

        protected override string MediaName
        {
            get { return "Movie"; }
        }
        public override string MainPersonRole
        {
            get { return "Director"; }
        }

    }
}
