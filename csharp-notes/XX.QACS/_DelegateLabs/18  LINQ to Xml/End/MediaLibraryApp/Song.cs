using System;
using System.Collections.Generic;
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
            MethodInvoker mi = new MethodInvoker(() =>
            {
                Console.WriteLine("PlayLoop thread = " + Thread.CurrentThread.ManagedThreadId);
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                    progressDel.Invoke(i);
                }
            });
            mi.BeginInvoke(null, null);
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
