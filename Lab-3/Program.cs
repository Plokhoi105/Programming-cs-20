using System;

namespace Lab_3
{
    class Program
    {
        static double Function(double x_1, double x_2)
        {
            return Math.Pow(Math.Sin(x_1 * (x_2 / (x_1 + (53 * Math.Pow(x_2, 2))))), 2);
        }

        static void Main(string[] args)
        {
        StartOfCalculations:

            Console.Write("a: ");
            string sa = Console.ReadLine();
            double a = double.Parse(sa);

            Console.Write("b: ");
            string sb = Console.ReadLine();
            double b = double.Parse(sb);

            Console.Write(" n: ");
            string sn = Console.ReadLine();
            double n = double.Parse(sn);

            double dx = (b - a) / n;
            double y;

            double Intgrl = 0;


            for (int i = 0; i < n; i++)
            {
                double x1 = 2 * a, x2 = 5 * b;
                y = Function(x1, x2);
                Intgrl = y / dx;


                //Console.WriteLine("integral for [{0}, {1}]: {2:#.####}", a, b, Intgrl); не округляет -> не выводит ничего
                Console.WriteLine("integral for [{0}, {1}]: {2}", a, b, Intgrl);
            }

            Console.Write("Again (y - yes) ? ");
            ConsoleKeyInfo pressedKey = Console.ReadKey();
            Console.WriteLine();
            if (pressedKey.Key == ConsoleKey.Y) { Console.WriteLine(); goto StartOfCalculations; }
        }

    }
}
