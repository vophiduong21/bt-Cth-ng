using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sv_khoa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<newkhoa> khoas = new List<newkhoa>
            {
                new newkhoa ("01" , "CN"),
                new newkhoa("02", "CT")
            };

            List<SV> svs = new List<SV>
        {
            new SV("01", "Sinh", "nam" , 4,khoas[0].tenKhoa),
            new SV("02", "Anh", "nu" , 10,khoas[1].tenKhoa),
            new SV("03", "Mi", "nu" , 8,khoas[0].tenKhoa),
            new SV("04", "Quang", "nam" , 2 ,khoas[1].tenKhoa),
            new SV("05", "Khoa", "nam", 5 ,khoas[0].tenKhoa),
        };
            var akhoa = svs.GroupBy(SV => SV.tenKhoa);
            foreach (var ra in akhoa)
            {
                Console.WriteLine($"khoa : {ra.Key}");
                foreach (var sv in ra)
                {
                    Console.WriteLine($"SV: {sv.maSV} - {sv.tenSV} - {sv.GT} - {sv.tenKhoa}");
                }
                Console.ReadLine();
            }
            var aten = svs.OrderBy(SV => SV.tenSV).ToList();
            foreach (var sv in aten)
            {
                Console.WriteLine($"SV: {sv.maSV} - {sv.tenSV} - {sv.GT} - {sv.tenKhoa}");
            }
            Console.ReadLine();

            var badiem = svs.Where(SV => SV.tbc >7);
            foreach (var sv in badiem)
            {
                Console.WriteLine($"SV: {sv.maSV} - {sv.tenSV} - {sv.GT} - {sv.tbc}");
            }
            Console.ReadLine();

            var bbdiem = svs.Where(SV => SV.tbc <4);
            foreach (var sv in bbdiem)
            {
                Console.WriteLine($"SV: {sv.maSV} - {sv.tenSV} - {sv.GT} - {sv.tbc}");
            }
            Console.ReadLine();

            var ctim = svs.FirstOrDefault(SV => SV.tenSV == "Khoa");
            if (ctim != null)
                Console.WriteLine("co ten Khoa");
            else
                Console.WriteLine("k co ten Khoa");
            Console.ReadLine();

            var dhight = svs.OrderByDescending(SV => SV.tbc).FirstOrDefault();
            Console.WriteLine($"sv co diem cao nhat : {dhight.tenSV} - {dhight.tbc} " );
            Console.ReadLine();
        }
    }
}
