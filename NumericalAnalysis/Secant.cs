using System;

namespace NumericalAnalysis
{
    public class Secant
    {
        public double Approximation { get; set; }

        public double p0 { get; set; }

        public double p1 { get; set; }

        public double TOL { get; set; }

        public int MaxInterations { get; set; }

        public Secant(double InitialApproximationOne,double InitialApproximationTwo, double TOL = 0.00001, int MaxInterations = 100)
        {
            this.MaxInterations = MaxInterations;
            this.p0 = InitialApproximationOne;
            this.p1 = InitialApproximationTwo;
            this.TOL = TOL;

            int i = 2;

            while (i <= MaxInterations)
            {
                Console.WriteLine(p1);

                double p = p1 - (f(p1) * (p1 - p0)) / (f(p1) - f(p0));

                if (Math.Abs(p - p1) < TOL)
                {
                    Approximation = p;
                    break;
                }

                p0 = p1;
                p1 = p;

            }
        }

        public double f(double x)
        {
            return cos(x) - x;
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
