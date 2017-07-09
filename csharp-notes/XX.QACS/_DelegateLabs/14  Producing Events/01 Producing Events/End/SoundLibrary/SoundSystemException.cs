using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLibrary {

    public class SoundSystemException : Exception {
        public SoundSystemException(string msg)
            : base(msg) {
        }
    }

}
