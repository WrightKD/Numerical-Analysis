using System;
using System.Collections.Generic;
using System.Text;

namespace NumericalAnalysis
{
    public class Steffensen
    {
        public double Approximation { get; set; }

        public double p0 { get; set; }

        public double TOL { get; set; }

        public int MaxInterations { get; set; }

        public Steffensen(double InitialApproximation, double TOL = 0.00001, int MaxInterations = 100)
        {
            this.MaxInterations = MaxInterations;
            this.p0 = InitialApproximation;
            this.TOL = TOL;

            int i = 1;

            while (i <= MaxInterations)
            {
                Console.WriteLine(p0);

                double p1 = g(p0);
                double p2 = g(p1);

                double p = p0 - power(p1 - p0, 2) / (p2 - 2 * p1 + p0);

                if (Math.Abs(p - p0) < TOL)
                {
                    Approximation = p;
                    break;
                }

                i++;

                p0 = p;

            }
        }



        public double g(double x)
        {
            return power(x, 3) + 4 * power(x, 2) - 10;
        }

        public double df(double x)
        {
            return 3 * power(x, 2) + 8 * x;
        }

        public double cos(double x)
        {
            return Math.Cos(x);
        }

        public double sin(double x)
        {
            return Math.Sin(x);

        }

        public double power(double x, double y)
        {
            return Math.Pow(x, y);
        }
    }
}
