using System;
using System.Security.Cryptography;

namespace BmiCalculator
{
    public class Class1
    {
        public decimal Calculate(decimal w, string ps, int a, string g, decimal h)
        {
            decimal c = 0;
            if (g == "woman")
            {
                if (ps == "zero")
                {
                    return c = (655m + 9.6m * w + 1.85m* h - 4.7m * a) * 1.0m;
                }
                else if (ps == "twoTimesWeek")
                {
                    return c = (655m + 9.6m * w + 1.85m* h - 4.7m * a) * 1.2m;
                }
                
                else if (ps == "fourTimesWeek")
                {
                    return c = (655m + 9.6m * w + 1.85m* h - 4.7m * a) * 1.5m;
                }
                else if (ps == "everyday")
                {
                    return c = (655m + 9.6m * w + 1.85m* h - 4.7m * a) * 2.0m;
                }
            }§
            else
            {
                Console.WriteLine("man doesnt care :)");
                return c = 9999999;
            }
            return c;
        }
    }
}