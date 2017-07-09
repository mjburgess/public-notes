using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibraryApp {
    class MediaItem {

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

    }
}
