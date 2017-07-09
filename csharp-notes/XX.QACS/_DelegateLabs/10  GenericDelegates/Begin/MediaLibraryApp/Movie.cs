using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibraryApp
{
    public class Movie : MediaItem, IPlayable
    {

        public Movie(string title, string director, string imageLocation, TimeSpan duration)
            : base(title, director, imageLocation)
        {
            this.Duration = duration;
        }

        protected override string MediaName
        {
            get { return "Movie"; }
        }
        public override string MainPersonRole
        {
            get { return "Director"; }
        }


        public void Play(ProgressDel progressDel)
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
