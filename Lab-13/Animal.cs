using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr8
{
    public class Animal
    {
        public string Name { get; set; }
        public string Country{ get; set; }
        public string Family{ get; set; }
        public double Population{ get; set; }
        public int Paws{ get; set; }
        public double Years{ get; set; }
        public bool HasWings{ get; set; }
        public bool IsPredator{ get; set; }

        public double YearsofLiving()
        {
            return Years;
        }
        public Animal()
        {
        }
        public Animal(string name, string country, string family, double population, int paws, double years, bool hasWings, bool isPredator)
        {
            Name = name; 
            Country = country;
            Family = family;
            Population = population;
            Paws = paws;
            Years = years; 
            HasWings = hasWings;
            IsPredator = isPredator;
        }
    }
}

