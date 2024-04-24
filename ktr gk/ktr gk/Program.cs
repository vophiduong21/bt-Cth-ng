using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktr_gk
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;

    class Khupho
    {
        public string TKhuPho { get; set; }
        public string Tgiadinh { get; set; }

        public Khupho(string TKhupho, string Tgiadinh)
        {
            this.TKhuPho = TKhupho;
            this.Tgiadinh = Tgiadinh;
        }
    }

    class GiaDinh : Khupho
    {
        public int Ctrai { get; set; }
        public int Cgai { get; set; }

        public GiaDinh(string Tgiadinh, int Ctrai, int Cgai) : base(null, Tgiadinh)
        {
            this.Ctrai = Ctrai;
            this.Cgai = Cgai;
        }
    }

    class TTCN
    {
        public string Name { get; set; }
        public int Tuoi { get; set; }
        public string Nghe { get; set; }
        public int CMND { get; set; }

        public TTCN(string Name, int Tuoi, string Nghe, int CMND)
        {
            this.Name = Name;
            this.Tuoi = Tuoi;
            this.Nghe = Nghe;
            this.CMND = CMND;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Khupho> khupho = new List<Khupho> { };
            List<GiaDinh> giaDinhs = new List<GiaDinh>
        {
            new GiaDinh("Hung", 3, 0),
            new GiaDinh("Phong", 7, 3),
            new GiaDinh("Nam", 0, 4)
        };

            Console.WriteLine("Nhap so luong ho gia dinh can nhap :");
            int n = int.Parse(Console.ReadLine());

            // Nhập thông tin của từng hộ gia đình
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap thong tin cho ho gia dinh {i + 1}:");
                Console.Write("Ten ho gia dinh: ");
                string tenGiaDinh = Console.ReadLine();
                Console.Write("So con trai: ");
                int soConTrai = int.Parse(Console.ReadLine());
                Console.Write("So con gai: ");
                int soConGai = int.Parse(Console.ReadLine());

                GiaDinh giaDinh = new GiaDinh(tenGiaDinh, soConTrai, soConGai);
                giaDinhs.Add(giaDinh);
                khupho.AddRange(giaDinhs);

            }


            foreach (var giaDinh in khupho)
            {
                Console.WriteLine($"Ho gia dinh: {giaDinh.Tgiadinh}, So con trai: {((GiaDinh)giaDinh).Ctrai}, So con gai: {((GiaDinh)giaDinh).Cgai}");
            }

            List<TTCN> ttcns = new List<TTCN>
        {
            new TTCN("Hung", 35, "cong nhan", 344097150),
            new TTCN("Phong", 40, "giao vien", 355077150),
            new TTCN("Nam", 37 , "ky su", 311757680),
        };

            Console.WriteLine("Nhap Ten Ho gia dinh muon tim :");
            var searchName = Console.ReadLine();

            SearchByName(khupho, searchName);

            contraihonnam(giaDinhs);

            timsocon(giaDinhs);

            giadinhhung(giaDinhs);

            TinhTongSoCon(khupho);

            Console.ReadKey();
        }

        private static void SearchByName(List<Khupho> khupho, string searchName)
        {
            var result = khupho.Where(item => item.Tgiadinh == searchName && item.GetType() == typeof(GiaDinh)).ToList();
            if (result.Any())
            {
                Console.WriteLine($"Danh sach {searchName}: ");
                foreach (var item in result)
                {
                    Console.WriteLine($"- {item.Tgiadinh}");
                }
            }
            else
                Console.WriteLine($"Khong co {searchName} trong danh sach!!!");
        }

        private static void contraihonnam(List<GiaDinh> giaDinhs)
        {
            var contraihonnam = giaDinhs.Where(gd => gd.Ctrai > 5);
            Console.WriteLine("\n Cac ho gia dinh co con trai lon hon 5 la : ");
            foreach (var giadinh in contraihonnam)
                Console.WriteLine($"- {giadinh.Tgiadinh}");
        }
        private static void timsocon(List<GiaDinh> giaDinhs)
        {
            var socon = giaDinhs.Where(gd => gd.Ctrai > 2 && (gd.Ctrai + gd.Cgai) >= 5 && (gd.Ctrai + gd.Cgai) <= 10);
            Console.WriteLine("\n Cac ho gia dinh co con trai lon hon 2 va gia dinh co so con tu 5 den 10 la : ");
            foreach (var giadinh in socon) Console.WriteLine($"- {giadinh.Tgiadinh}");
        }
        private static void giadinhhung(List<GiaDinh> giaDinhs)
        {
            var giadinhhung = giaDinhs.Where(gd => gd.Tgiadinh == "Hung");
            Console.WriteLine("\n Cac Ho Gia dinh co nguoi ten Hung la :");
            foreach (var giadinh in giadinhhung)
                Console.WriteLine($"Ho gia dinh: {giadinh.Tgiadinh}, So con trai: {giadinh.Ctrai}, So con gai: {giadinh.Cgai}");
        }
        private static void TinhTongSoCon(List<Khupho> khupho)
        {
            int tongSoConTrai = 0;
            int tongSoConGai = 0;

            foreach (var item in khupho)
            {
                if (item is GiaDinh)
                {
                    tongSoConTrai += ((GiaDinh)item).Ctrai;
                    tongSoConGai += ((GiaDinh)item).Cgai;
                }
            }

            Console.WriteLine($"Tong so con trai trong khu pho: {tongSoConTrai}");
            Console.WriteLine($"Tong so con gai trong khu pho: {tongSoConGai}");
        }


    }

}
