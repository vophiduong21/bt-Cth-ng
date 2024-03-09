using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2
{
    class car : vehicle
    {
        public car(string brand, int year, double price)
        {
            Brand = brand;
            Year = year;
            Price = price;
        }
    }
}
