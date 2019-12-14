using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab06Lib;
namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals[] arranim;

            Console.Write(" num of listed animals: ");
            int cntanimals = int.Parse(Console.ReadLine());
            arranim = new Animals[cntanimals];

            for (int i = 0; i < cntanimals; i++)
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

                Animals animal = new Animals();
                animal.Name = sName;
                animal.Country = sCountry;
                animal.Family = sFamily;
                animal.Population = int.Parse(sPopulation);
                animal.Paws = double.Parse(sPaws);
                animal.Years = double.Parse(sYears);
                animal.HasWings = keyHasWings.Key == ConsoleKey.Y ? true : false;
                animal.IsPredator = keyIsPredator.Key == ConsoleKey.Y ? true : false;

                arranim[i] = animal;
            }

            foreach (Animals a in arranim)
            {
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine(" current data about {0}," + a.Name);
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine(" name: " + a.Name);
                Console.WriteLine(" country: " + a.Country);
                Console.WriteLine(" family: " + a.Family);
                Console.WriteLine(" population: " + a.Population.ToString());
                Console.WriteLine(" paws: " + a.Paws.ToString("0"));
                Console.WriteLine(" average of living: " + a.yearsofanimals.ToString("0.00"));
                Console.WriteLine(a.HasWings ? " has wings" : " no wings");
                Console.WriteLine(a.IsPredator ? " a predar" : " herbivorous");
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}

