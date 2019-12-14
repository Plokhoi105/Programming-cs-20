using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    class Town

    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Family { get; set; }
        public int Population { get; set; }
        public double Paws { get; set; }
        public double Years { get; set; }
        public bool HasWings { get; set; }
        public bool IsPredator { get; set; }

        public Town()
        {

        }
        public double YearsofLiving()
        {
            return Years;
        }




    }
}
