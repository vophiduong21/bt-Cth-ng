using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meobkten
{
    class nhanvien : phongban
    {
        public string maNV { get; set; }
        public string tenNV { get; set; }
        public string ngaySinh { get; set; }
        public int Tuoi { get; set; }

        public nhanvien() { }
        public nhanvien(string manv , string tennv , string ngaysinh , int tuoi , string tenpb)
        {
            maNV = manv;
            tenNV = tennv;
            ngaySinh = ngaysinh;
            Tuoi = tuoi;
            tenPB = tenpb;
        }
    }
}
