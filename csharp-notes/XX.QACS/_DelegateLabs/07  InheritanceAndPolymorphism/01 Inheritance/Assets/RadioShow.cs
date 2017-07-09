using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaLibrary {
    public class RadioShow : PlayableMediaItem {

        public RadioShow(string title, string mainPerson) : base(title,mainPerson) {
            MainPersonRole = "Presenter";
        }

        public override void Pause() {
            Console.WriteLine("RadioShow.Pause");
        }

        public override void Play() {
            Console.WriteLine("RadioShow.Play");
        }

        public override void Stop() {
            Console.WriteLine("RadioShow.Stop");
        }

        protected override bool CheckLicence(Licence lic) {
            Console.WriteLine("RadioShow.CheckLicence");
            return lic.IsValid;
        }

        protected override Licence ObtainLicence() {
            Console.WriteLine("RadioShow.ObtainLicence");
            return new Licence();
        }
    }
}
