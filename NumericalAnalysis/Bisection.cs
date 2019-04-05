using System;

namespace NumericalAnalysis
{
    public class Bisection
    {
        // f is a continuous function on an interval [a,b]
        // f(a) and f(b) are of opposite signs
        // Intermediate Value Theorem implies that a number p exists in (a,b) with f(p) = 0

        public double Approximation { get; set; }

        double a = 0;
        double b = 1;

        double TOL = 0.0001;

        

        int NumOfInterations = 1000;

        public Bisection(double a,double b,double TOL)
        {
            this.a = a;
            this.b = b;
            this.TOL = TOL;
            double f_a = 0;
            double f_p = 0;

            for (int i = 0; i < NumOfInterations; i++)
            {
                f_a = f(a);

                double p = a + (b - a) / 2; // Midpoint

                f_p = f(p);

                Console.WriteLine(p);

                if (f_p == 0 || (b-a)/2 < TOL)
                {
                    Approximation = p;
                    break;
                }

                if (f_a*f_p > 0)
                {
                    a = p;

                }
                else
                {
                    b = p;
                }

            }

        }


        public double f(double x)
        {
            return x - ((power(x,3)+4*power(x,2)-10)/(3*power(x,2)+8*x));
        }

        public double cos(double x)
        {
            return Math.Cos(x);
        }

        public double power(double x , double y)
        {
            return Math.Pow(x, y);
        }

       


    }

   
}
