using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLibrary
{

    public class Sound
    {

        public static void Initialize(SetLevelsDel levels)
        {
            // TODO check for null delegate
            if (levels == null)
            {
                throw new SoundSystemException("passed in delegate was null. Some sensitive information is also present in the message");
            }
            levels.Invoke(8.0);
        }

    }

}
