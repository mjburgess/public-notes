using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibraryApp
{
    public class Song : MediaItem, IPlayable
    {

        public Song(string title, string artist, string imageLocation, TimeSpan duration)
            : base(title, artist, imageLocation /*duration,*/)
        {
            this.Duration = duration;
        }

        protected override string MediaName
        {
            get { return "Song"; }
        }
        public override string MainPersonRole
        {
            get { return "Artist"; }
        }


        public void Play()
        {
            Status = string.Format("Playing {0} {1}", MediaName, Title);
        }

        public void Pause()
        {
            Status = string.Format("{0} {1} is paused", MediaName, Title);
        }

        public void Stop()
        {
            Status = string.Format("Stopped {0} {1}", MediaName, Title);
        }

        public TimeSpan Duration
        {
            get;
            private set;
        }
    }
}
