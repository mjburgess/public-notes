using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MediaLibraryApp
{
    public class Song : MediaItem, IPlayable
    {

        public Song(string title, string artist, string imageLocation, TimeSpan duration)
            : base(title, artist, imageLocation)
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


        public void Play(ProgressDel progressDel)
        {
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.WorkerReportsProgress = true;
            bgw.DoWork += (o, e) =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                    bgw.ReportProgress(i);
                }
            };
            bgw.ProgressChanged += (o, e) => progressDel.Invoke(e.ProgressPercentage);
            bgw.RunWorkerAsync();

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

        public override string ToString()
        {
            return base.ToString() + ", mins=" + Duration.TotalMinutes;
        }


        public override XElement ToXML()
        {
            XElement song = ToXML_MediaItem();
            song.Add(new XElement("Duration", Duration.ToString()));
            return song;
        }

        internal Song(XElement songElement)
            : base(songElement)
        {
            TimeSpan duration;
            TimeSpan.TryParse(songElement.Element("Duration").Value, out duration);
            Duration = duration;
        }
    }
}
