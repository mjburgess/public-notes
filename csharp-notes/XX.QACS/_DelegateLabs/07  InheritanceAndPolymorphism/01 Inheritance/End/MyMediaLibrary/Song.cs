using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaLibrary {
    public class Song : PlayableMediaItem {

        public Song(string title, string mainPerson) 
            : base(title, mainPerson) {
            MainPersonRole = "Artist";
        }

        public override void Pause() {
            Console.WriteLine("Song.Pause");
        }

        public override void Play() {
            Console.WriteLine("Song.Play");
        }

        public override void Stop() {
            Console.WriteLine("Song.Stop");
        }

        protected override bool CheckLicence(Licence lic) {
            Console.WriteLine("Song.CheckLicence");
            return true;
        }

        protected override Licence ObtainLicence() {
            Console.WriteLine("Song.ObtainLicence");
            return null;
        }
    }
}
