using System;
using System.Collections.Generic;
using System.Text;

namespace NumericalAnalysis
{
    public class FixedPoint
    {
        public double Approximation { get; set; }

        public double  InitialApproximation { get; set; }

        public double  TOL { get; set; }

        public int MaxInterations { get; set; }

        public FixedPoint(double InitialApproximation, double TOL = 0.00001, int MaxInterations = 100)
        {
            this.MaxInterations = MaxInterations;
            this.InitialApproximation = InitialApproximation;
            this.TOL = TOL;


            int i = 1;

            while (i <= MaxInterations)
            {
                //Console.WriteLine(InitialApproximation);

                double p = g(InitialApproximation);

                if(Math.Abs(p - InitialApproximation) < TOL)
                {
                    Approximation = p;
                    break;
                }

                i++;

                InitialApproximation = p;
            }
        }
        public double g(double x)
        {
            return x - ((power(x, 3) + 4 * power(x, 2) - 10) / (3 * power(x, 2) + 8 * x));
        }

        public double cos(double x)
        {
            return Math.Cos(x);
        }

        public double power(double x, double y)
        {
            return Math.Pow(x, y);
        }

    }
}
