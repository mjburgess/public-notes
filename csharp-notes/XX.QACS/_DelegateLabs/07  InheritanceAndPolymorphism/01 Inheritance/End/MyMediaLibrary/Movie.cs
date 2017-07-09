using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaLibrary {
    public class Movie : PlayableMediaItem {

        public Movie(string title, string mainPerson) 
            : base(title, mainPerson) {
            MainPersonRole = "Director";
        }

        public override void Pause() {
            Console.WriteLine("Movie.Pause");
        }

        public override void Play() {
            Console.WriteLine("Movie.Play");
        }

        public override void Stop() {
            Console.WriteLine("Movie.Stop");
        }

        protected override bool CheckLicence(Licence lic) {
            Console.WriteLine("Movie.CheckLicence");
            return true;
        }

        protected override Licence ObtainLicence() {
            Console.WriteLine("Movie.ObtainLicence");
            return null;
        }
    }
}
