using System;
using System.Diagnostics;
using System.Threading;

namespace NumericalAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {

            //Bisection bisection = new Bisection(0, 1, 0.000001);

            //Console.WriteLine(bisection.Approximation);

            //FixedPoint fixedPoint = new FixedPoint(1.5);

            //Console.WriteLine(fixedPoint.Approximation);

            //NewtonRaphson newton = new NewtonRaphson(1.5);

            //Console.WriteLine(newton.Approximation + "---");

            //Secant secant = new Secant(0.5, Math.PI / 4.0);

            //Console.WriteLine(secant.Approximation);

            //FalsePosition falsePosition = new FalsePosition(0.5, Math.PI / 4.0);

            //Console.WriteLine(falsePosition.Approximation);

            //ModifiedNewton modifiedNewton = new ModifiedNewton(1.5);

            //Console.WriteLine(modifiedNewton.Approximation);

            Stopwatch stopwatch = Stopwatch.StartNew();

            stopwatch.Start();
            Simpson simpson4 = new Simpson(0, 4, 4);
            stopwatch.Stop();

            Console.WriteLine(simpson4.Approximation + " calculated in " + stopwatch.ElapsedMilliseconds);

            stopwatch.Start();
            Simpson simpson8 = new Simpson(0, 4, 8);
            stopwatch.Stop();

            Console.WriteLine(simpson8.Approximation + " calculated in " + stopwatch.ElapsedMilliseconds);

            stopwatch.Start();
            Simpson simpson2048 = new Simpson(0, 4, 2048);
            stopwatch.Stop();

            Console.WriteLine(simpson2048.Approximation + " calculated in " + stopwatch.ElapsedMilliseconds);

            stopwatch.Start();
            Simpson simpsonE = new Simpson(0, 4,(int) Math.Pow(2,100));
            stopwatch.Stop();

            Console.WriteLine(simpsonE.Approximation + " calculated in " + stopwatch.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
