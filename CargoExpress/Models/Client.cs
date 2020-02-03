using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoExpress.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PhoneNumber { get; set; }
        public string PlaceStart { get; set; }
        public string PlaceEnd { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
    }
}
