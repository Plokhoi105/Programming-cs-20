using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Xmin: ");
            string sxMin = Console.ReadLine();
            double xMin = Double.Parse(sxMin);

            Console.Write(" Xmax: ");
            string sxMax = Console.ReadLine();
            double xMax = Double.Parse(sxMax);

            Console.Write("\n dX: ");
            string sdx = Console.ReadLine();
            double dx = double.Parse(sdx);

            double x = xMin;
            double y = 0;
            double sum = 0;

            while (x <= xMax)
            {
                y = ((Math.Sqrt(Math.Pow(x, 3) + Math.Pow(xMax, 5))) / 1000) + 65;
                Console.WriteLine("x = {0:#.####}\t\t y = {1:#.####}", x, y);
                x += dx;

                if (y > 0)
                {
                    sum += y;
                }
            }

            Console.WriteLine("\n sum: " + sum);
            Console.ReadKey();
        }

    }
}
