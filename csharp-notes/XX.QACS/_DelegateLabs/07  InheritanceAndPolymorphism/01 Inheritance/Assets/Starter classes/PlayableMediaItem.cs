using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaLibrary {
    public class PlayableMediaItem {

        // This is technique is a design pattern called Template Method
        public bool IsAuthorized {
            get {
                Licence licence = ObtainLicence();
                bool isAuthorized = CheckLicence(licence);
                LogLicence(licence);
                return isAuthorized;
            }
        }
        protected abstract Licence ObtainLicence();
        protected abstract bool CheckLicence(Licence lic);
        private void LogLicence(Licence lic) {
            Console.WriteLine("PlayableMediaItem.LogLicence");
        }

        // Media Control
        public abstract void Play();
        public abstract void Pause();
        public abstract void Stop();
    }
}
