using System;


namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Xmin: ");
            string sxMin = Console.ReadLine();
            double xMin = Double.Parse(sxMin);

            double xMax = xMin * 3;
            Console.Write(" Xmax: " + xMax);

            Console.Write("\n dX: ");
            string sdx = Console.ReadLine();
            double dx = double.Parse(sdx);

            double x = xMin;
            double y = 0;
            double sum = 0;

            while (x <= xMax)
            {
                y = (Math.Pow(Math.Sin(x), 3) + 45 + xMax) / (2 * Math.Pow(x, 4) + 4 * xMax);
                Console.WriteLine("x = {0}\t\t y = {1}", x, y);
                x += dx;

            }


            if (x > xMin && x < xMax)
            {
                sum += y;
            }

            Console.WriteLine("\n sum: " + sum);
            Console.ReadKey();
        }

    }
}
