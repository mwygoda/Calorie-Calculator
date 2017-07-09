using System;

namespace BmiCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CalorieNeedsCalculator calorieCounter = new CalorieNeedsCalculator();
            var result = calorieCounter.CalculateCalorieNeeds(90.5m, "zero", 50, "woman", 175.4m);
            Console.WriteLine(result);
        }
    }
}/////Calculate(decimal w, string ps, int a, string g, decimal h)