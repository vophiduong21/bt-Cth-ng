using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meobkten
{
    class Program
    {
        static int chon;
        static void Main(string[] args)
        {
            List<phongban> pbs = new List<phongban>
            {
                new phongban("1" , "pb1"),
                new phongban("2" , "pb2"),
                new phongban("3" , "pb3"),
                new phongban("4" , "pb4")
            };

            List<nhanvien> nvs = new List<nhanvien>
            {
                new nhanvien("1","Anh","2/2/2001",23,pbs[0].tenPB),
                new nhanvien("2","Anh","2/2/2001",23,pbs[1].tenPB),
                new nhanvien("3","Anh","2/2/2001",23,pbs[2].tenPB),
                new nhanvien("4","Anh","2/2/2001",23,pbs[3].tenPB),
                new nhanvien("5","Anh","2/2/2001",23,pbs[1].tenPB),
                new nhanvien("6","Anh","2/2/2001",23,pbs[0].tenPB)
            };
            void findAge(List<nhanvien> TTNV, int ageStart , int ageEnd)
            {
                Console.WriteLine($"Employees with age {ageStart} - {ageEnd}:");
                var findage_list = nvs.Where(nhanvien => nhanvien.Tuoi > ageStart & nhanvien.Tuoi < ageEnd);
                foreach (var dem in findage_list)
                {
                    Console.WriteLine($"{dem.maNV} , {dem.tenNV} , {dem.tenPB} , {dem.ngaySinh}");
                }
                Console.ReadLine();
                
            }

            Console.WriteLine("1. tim tuoi \n2. ten\n0.Exit");
            Console.WriteLine("moi chon");
            do
            {
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 0:
                        Console.WriteLine("Stop");
                        Console.ReadLine();
                        break;
                    case 1:
                        Console.WriteLine("nhap tuoi bat dau : ");
                        int ageStart = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("nhap tuoi ket thuc : ");
                        int ageEnd = Convert.ToInt32(Console.ReadLine());
                        findAge(nvs, ageStart, ageEnd);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("moi chon tiep");
            } while (chon != 0);

        }
    }
}
