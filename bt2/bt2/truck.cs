using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2
{
    class truck : vehicle
    {
        public string Company { get; set; }
        public truck(string brand, int year, double price , string company)
        {
            Brand = brand;
            Year = year;
            Price = price;
            Company = company;
        }
    }
}
