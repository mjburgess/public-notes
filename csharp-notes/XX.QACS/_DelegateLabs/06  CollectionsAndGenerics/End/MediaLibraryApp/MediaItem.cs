using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace MediaLibraryApp
{
    public class MediaItem {

        public string Title { get; set; }
        public string Artist { get; set; }

        private string mediaType;

        public string MediaType {
            get { return mediaType; }
            set {
                if (value == "Movie" || value == "Song") {
                    mediaType = value;
                } else {
                    mediaType = "Unknown";
                }
            }
        }

        public override string ToString() {
            return "Title=" + Title + ", Artist=" + Artist;
        }



        public TimeSpan Duration { get; private set; }
        public Rating Rating { get; set; }
        public string ImageLocation { get; private set; }

        public MediaItem(string title, string artist, string imageLocation, string mediaType, TimeSpan duration) {
            this.Title = title;
            this.Artist = artist;
            this.ImageLocation = imageLocation;
            this.mediaType = mediaType;
            this.Duration = duration;
        }


        private string status = "unknown";
        public string Status {
            get { return status; }
        }
        public void Play() {
            status = string.Format("Playing {0} {1}", MediaType, Title);
        }

        public void Pause() {
            status = string.Format("{0} {1} is paused", MediaType, Title);
        }

        public void Stop() {
            status = string.Format("Stopped {0} {1}", MediaType, Title);
        }

    }
}
