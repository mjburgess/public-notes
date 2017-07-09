using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibraryApp {
    public class MediaLibrary {
        public string Title { get; set; }

        private List<MediaItem> items;

        public List<MediaItem> Items {
            get {
                if (items == null) {
                    items = new List<MediaItem>();
                }
                return items;
            }
        }


        // The indexer
        public MediaItem this[int index] {
            get {
                return items[index];
            }
            set {
                items[index] = value;
            }
        }

    }
}
