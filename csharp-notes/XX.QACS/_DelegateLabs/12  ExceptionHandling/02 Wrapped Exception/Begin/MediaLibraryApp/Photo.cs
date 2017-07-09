using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MediaLibraryApp
{
    public class Photo : MediaItem
    {

        public Photo(string title, string photographer, string imageLocation)
            : base(title, photographer, imageLocation)
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

        public override XElement ToXML()
        {
            XElement photo = ToXML_MediaItem();
            return photo;
        }

        internal Photo(XElement photoElement)
            : base(photoElement)
        {
        }
    }
}
