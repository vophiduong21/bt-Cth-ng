using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<car> cars = new List<car>
        {
            new car("Toyota", 1995, 150000),
            new car("Toyota", 2000, 180000),
            new car("Ford", 2005, 220000),
            new car("Chevrolet", 1989, 120000),
            new car("Nissan", 2008, 260000),
        };

            var acar = cars.Where(car => car.Price >= 100000 && car.Price <= 250000);
            Console.WriteLine("price 100000-250000 : ");
            foreach( var xe in acar)
            {
                Console.WriteLine("xe : {0} , nam : {1} , gia {2}" , xe.Brand , xe.Year , xe.Price);
            }
            Console.ReadLine();

            var bcar = cars.Where(car => car.Year >1990);
            Console.WriteLine("year > 1990 : ");
            foreach (var xe in bcar)
            {
                Console.WriteLine("xe : {0} , nam : {1} , gia {2}", xe.Brand, xe.Year, xe.Price);
            }
            Console.ReadLine();

            var groupc = cars.GroupBy(car => car.Brand).Select(group => new { Brand = group.Key, TotalPrice = group.Sum(car => car.Price) });
            Console.WriteLine("dem : ");
            foreach (var xe in groupc)
            {
                Console.WriteLine("hang : {0} , tong : {1}", xe.Brand , xe.TotalPrice);
            }
            Console.ReadLine();


            List<truck> trucks = new List<truck>
        {
            new truck("Volvo", 2015, 1500000, "Volvo Group"),
            new truck("Scania", 2010, 1200000, "Scania AB"),
            new truck("Mercedes-Benz", 2018, 2000000, "Daimler AG"),
        };
            var b2car = trucks.OrderByDescending(truck => truck.Year);
            Console.WriteLine("moi : ");
            foreach (var xe in b2car)
            {
                Console.WriteLine("xe : {0} , nam : {1} , gia : {2} , cty : {3}", xe.Brand, xe.Year, xe.Price , xe.Company);
            }
            Console.ReadLine();

            Console.WriteLine("cty : ");
            foreach (var xe in trucks)
            {
                Console.WriteLine("cty : {0} ,xe : {1}", xe.Company , xe.Brand);
            }
            Console.ReadLine();

        }
    }
}
