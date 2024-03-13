using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sv_khoa
{
    class SV :Khoa
    {
        public string maSV { get; set; }
        public string tenSV { get; set; }
        public string GT { get; set; }
        public double tbc { get; set; }



        public SV (string masv, string tensv, string gt , double tb ,  string tk)
        {
            maSV = masv;
            tenSV = tensv;
            GT = gt;
            tenKhoa = tk;
            tbc = tb;
            
        }
    }
}
