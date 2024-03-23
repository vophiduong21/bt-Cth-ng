using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meobkten
{
    class phongban
    {
        public string maPB { get; set; }
        public string tenPB { get; set; }

        public phongban() { }

        public phongban(string mapb , string tenpb)
        {
            maPB = mapb;
            tenPB = tenpb;
        }
    }

}
