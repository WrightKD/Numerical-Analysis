using System;
using System.Collections.Generic;
using System.Text;

namespace NumericalAnalysis
{
   public class Simpson
    {
        public double Approximation { get; set; }

        public double a { get; set; }

        public double b { get; set; }

        public double IntervalWidth { get; set; }

        public Simpson(double a,double b, int IntervalWidth)
        {
            this.a = a;
            this.b = b;
            this.IntervalWidth = b/IntervalWidth;

            while(a != b)
            {
               double p0 = a;
               double p1 = a += this.IntervalWidth;

                Approximation += SimpsonFunction(p0, p1);
            }


        }

        public double f(double x)
        {
            return power(2,-1*power(x,2));
        }

        public double SimpsonFunction(double a,double b)
        {
            return (b - a) / 6 * (f(a) + 4 * f(half(a, b)) + f(b));
        }
       
        public double half(double a,double b)
        {
            return (a + b) / 2;
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
