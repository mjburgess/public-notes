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
            try {
                SoundLibrary.Sound.Initialize(levels);
            } catch (SoundSystemException ex) {
                throw new BenignException("Sorry we are experiencing difficulties with the sound system", ex);
            }
        }
    }
}
