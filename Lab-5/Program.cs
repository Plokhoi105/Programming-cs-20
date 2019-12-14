using System;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" the name of animal: ");
            string sName = Console.ReadLine();

            Console.Write(" country/region: ");
            string sCountry = Console.ReadLine();

            Console.Write(" family: ");
            string sFamily = Console.ReadLine();

            Console.Write(" num of population : ");
            string sPopulation = Console.ReadLine();

            Console.Write(" num of paws: ");
            string sPaws = Console.ReadLine();

            Console.Write("average life expectancy: ");
            string sYears = Console.ReadLine();

            Console.Write(" does it have wings? (y-yes, n-no): ");
            ConsoleKeyInfo keyHasWings = Console.ReadKey();
            Console.WriteLine();

            Console.Write(" is it a predator? (y-yes, n-no): ");
            ConsoleKeyInfo keyIsPredator = Console.ReadKey();
            Console.WriteLine();

            Town OurTown = new Town();

            OurTown.Name = sName;
            OurTown.Country = sCountry;
            OurTown.Family = sFamily;
            OurTown.Population = int.Parse(sPopulation);
            OurTown.Paws = double.Parse(sPaws);
            OurTown.Years = double.Parse(sYears);
            OurTown.HasWings = keyHasWings.Key == ConsoleKey.Y ? true : false;
            OurTown.IsPredator = keyIsPredator.Key == ConsoleKey.Y ? true : false;

            double Year = OurTown.YearsofLiving();

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(" current data: ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(" name: " + OurTown.Name);
            Console.WriteLine(" country: " + OurTown.Country);
            Console.WriteLine(" family: " + OurTown.Family);
            Console.WriteLine(" population: " + OurTown.Population.ToString());
            Console.WriteLine(" paws: " + OurTown.Paws.ToString("0"));
            Console.WriteLine(" average of living: " + Year.ToString("0.00"));
            Console.WriteLine(OurTown.HasWings ? " has wings" : " no wings");
            Console.WriteLine(OurTown.IsPredator ? " a predar" : " herbivorous");
            Console.WriteLine();


            Console.ReadKey();

        }
    }
}

