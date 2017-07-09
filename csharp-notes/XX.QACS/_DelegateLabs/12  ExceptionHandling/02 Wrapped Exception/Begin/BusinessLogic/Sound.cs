using Common;
using SoundLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Sound
    {
        public static void Initialize(SetLevelsDel levels) {
            SoundLibrary.Sound.Initialize(levels);
        }
    }
}
