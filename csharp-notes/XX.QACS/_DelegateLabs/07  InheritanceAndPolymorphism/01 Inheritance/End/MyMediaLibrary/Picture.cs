using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaLibrary {
    public class Picture : MediaItem {
        public Picture(string title, string mainPerson) 
            : base(title, mainPerson) {
            MainPersonRole = "Photographer";
        }
    }
}
