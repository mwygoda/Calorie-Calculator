using System;

namespace BmiCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 counter = new Class1();
            var result = counter.Calculate(90.5m, "zero", 50, "woman", 175.4m);
            Console.WriteLine(result);
        }
    }
}/////Calculate(decimal w, string ps, int a, string g, decimal h)