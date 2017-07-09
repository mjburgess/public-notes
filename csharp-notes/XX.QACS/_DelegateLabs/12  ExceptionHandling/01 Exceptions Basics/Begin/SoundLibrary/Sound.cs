using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLibrary {

    public class Sound {

        public static void Initialize(SetLevelsDel levels) {
            // TODO check for null delegate
            levels.Invoke(8.0);
        }

    }

    public delegate void SetLevelsDel(double bassBoost);
}
