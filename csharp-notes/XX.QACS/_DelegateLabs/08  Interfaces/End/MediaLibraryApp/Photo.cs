using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibraryApp
{
    public class Photo : MediaItem
    {

        public Photo(string title, string photographer, string imageLocation)
            : base(title, photographer, imageLocation /*new TimeSpan() ,*/)
        {
        }
        protected override string MediaName
        {
            get { return "Photo"; }
        }
        public override string MainPersonRole
        {
            get { return "Photographer"; }
        }

    }
}
