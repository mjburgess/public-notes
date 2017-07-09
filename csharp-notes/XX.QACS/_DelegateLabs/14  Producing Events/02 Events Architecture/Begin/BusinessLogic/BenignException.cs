using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic {
    public class BenignException : Exception {
        public BenignException(string msg)
            : base(msg) {
        }

        public BenignException(string msg, Exception ex)
            : base(msg, ex) {
        }


    }
}
