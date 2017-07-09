using System;

namespace BmiCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var Juliet = new Patient
            {
                gender = Constants.WOMAN_GENDER,
                bodyWeight = 90.5m,
                physicalActivityLevel = Constants.PHISICAL_ACTIVITY_LOW,
                age = 50,
                height = 174.4m
            };
            var factory = new CalorieNeedsCalculatorFactory();
            var mailSender = new MailSender();
            
            var calorieCounter = new CalorieNeedsCalculator(factory, mailSender);
            var result = calorieCounter.CalculateCalorieNeeds(Juliet);
            Console.WriteLine(result);
        }
    }
}