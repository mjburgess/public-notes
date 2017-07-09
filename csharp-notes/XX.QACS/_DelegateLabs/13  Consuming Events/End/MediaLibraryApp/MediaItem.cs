using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using static MediaLibraryApp.Rating;

namespace MediaLibraryApp
{
    public abstract class MediaItem
    {

        public string Title { get; set; }

        private string mainPerson;
        public string MainPerson
        {
            get { return mainPerson; }
        }
        public abstract string MainPersonRole { get; }
        public string MainPersonAndRole
        {
            get { return string.Format("{0} ({1})", mainPerson, MainPersonRole); }
        }

        protected abstract string MediaName { get; }

        public override string ToString()
        {
            return "Title=" + Title + ", MainPerson=" + MainPerson;
        }


        public Rating Rating { get; set; } = Unrated;
        public string ImageLocation { get; private set; }

        public MediaItem(string title, string mainPerson, string imageLocation)
        {
            this.Title = title;
            this.mainPerson = mainPerson;
            this.ImageLocation = imageLocation;
        }


        private string status = "unknown";
        public string Status
        {
            get { return status; }
            protected set { status = value; }
        }

        public override bool Equals(object obj)
        {
            return ToString().Equals(obj.ToString());
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public abstract XElement ToXML();

        protected XElement ToXML_MediaItem()
        {
            return new XElement(MediaName,
              new XElement("Title", Title),
              new XElement("ImageLocation", ImageLocation),
              new XElement("Rating", Rating),
              new XElement("MainPerson", MainPerson));
        }


        internal MediaItem(XElement mediaElement)
        {
            Title = mediaElement.Element("Title").Value;
            ImageLocation = mediaElement.Element("ImageLocation").Value;
            Rating rating;
            Enum.TryParse(mediaElement.Element("Rating").Value, out rating);
            Rating = rating;
            mainPerson = mediaElement.Element("MainPerson").Value;
        }

    }
}
