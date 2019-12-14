using System;

namespace Lab06Lib
{
    public class Animals
    {
        public string Name;
        public string Country;
        public string Family;
        public int Population;
        public double Paws;
        public double Years;
        public bool HasWings;
        public bool IsPredator;

        public double yearsofanimals { get { return YearsofLiving(); } }
        public double YearsofLiving()
        {
            return Years;
        }
    }

}

