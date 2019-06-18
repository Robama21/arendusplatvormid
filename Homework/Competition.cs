using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Homework {
    class Competition {
        public int Spots { get; set; }
        public string Nick { get; set; }
        public Competition(int spots, string nick) {
            Spots = spots;
            Nick = nick;
        }
    }
}
