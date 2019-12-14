using System;

namespace Lab_4
{
    class Program
    {
        const double X = 10.3;
        const double dX = 0.7;
        static double Function(double x_1, double x_2)
        {
            return (4 * Math.Sin(3 + x_1 * x_2)) / (34 - 9 * Math.Pow(x_2, 3));
        }

        static void Main(string[] args)
        {
            double[] arr = new double[10];

            double x = X;

            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                double x1 = 2.76 * x, x2 = 0.5 * x;
                arr[i] = Function(x1, x2);
                x += dX;
            }

            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine("from higher to lower: ");

            double aAvg = 0;
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                Console.WriteLine("arr[{0:00}] = {1:0.0000}", i, arr[i]);
                aAvg += arr[i];
            }

            aAvg = aAvg / arr.GetLength(0);
            Console.WriteLine("average: {0:0.0000}", aAvg);

            int k = 0;
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                if (arr[i] < aAvg)
                {
                    k++;
                }
            }
            Console.WriteLine("lower than average : " + k);
            Console.ReadKey(true);
        }

    }
}
