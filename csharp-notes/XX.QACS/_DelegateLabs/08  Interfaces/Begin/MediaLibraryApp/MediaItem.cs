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

        public TimeSpan Duration { get; private set; }
        public Rating Rating { get; set; } = Unrated;
        public string ImageLocation { get; private set; }

        public MediaItem(string title, string mainPerson, string imageLocation, TimeSpan duration)
        {
            this.Title = title;
            this.mainPerson = mainPerson;
            this.ImageLocation = imageLocation;
            this.Duration = duration;
        }


        private string status = "unknown";
        public string Status
        {
            get { return status; }
        }
        public void Play()
        {
            status = string.Format("Playing {0} {1}", MediaName, Title);
        }

        public void Pause()
        {
            status = string.Format("{0} {1} is paused", MediaName, Title);
        }

        public void Stop()
        {
            status = string.Format("Stopped {0} {1}", MediaName, Title);
        }

        public override bool Equals(object obj)
        {
            return ToString().Equals(obj.ToString());
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
