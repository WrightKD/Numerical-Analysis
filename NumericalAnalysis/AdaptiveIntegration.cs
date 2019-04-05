using System;
using System.Collections.Generic;
using System.Text;

namespace NumericalAnalysis
{
    public class AdaptiveIntegration
    {
        public double Approximation { get; set; }

        public double a { get; set; }

        public double b { get; set; }

        public int TOL { get; set; }

        public AdaptiveIntegration()
        {

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

        public double half(double a, double b)
        {
            return (a + b) / 2;
        }
    }
}
