using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaLibrary {
    public class MediaItem {
        public string Title { get; }
        public string MainPerson { get; }
        public string MainPersonRole { get; protected set; }

        public MediaItem(string title, string mainPerson) {
            Title = title;
            MainPerson = mainPerson;
        }
    }
}
