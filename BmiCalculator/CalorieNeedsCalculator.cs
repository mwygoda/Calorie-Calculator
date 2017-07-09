using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace BmiCalculator
{
    public class CalorieNeedsCalculator
    {
        private readonly ICalorieNeedsCalculatorFactory _factory;
        private readonly IMailSender _mailSender;

        public CalorieNeedsCalculator(ICalorieNeedsCalculatorFactory factory,
            IMailSender mailSender)
        {
            _factory = factory;
            _mailSender = mailSender;
        }
        public decimal CalculateCalorieNeeds(Patient patient)
        {

            decimal calorieNeeds = 0;
            if (patient.gender == Constants.WOMAN_GENDER)
            {
                switch (patient.physicalActivityLevel)
                {
                    case Constants.PHISICAL_ACTIVITY_ZERO:
                        calorieNeeds = _factory.GetCalorieNeedsCalculator().CalculateCalorieNeeds(patient, Constants.MULTIPLER_FOR_ZERO_ACTIVITY );
                        break;
                    case Constants.PHISICAL_ACTIVITY_LOW:
                        calorieNeeds = _factory.GetCalorieNeedsCalculator().CalculateCalorieNeeds(patient, Constants.MULTIPLER_FOR_LOW_ACTIVITY);
                        break;
                    case Constants.PHISICAL_ACTIVITY_MEDIUM:
                        calorieNeeds = _factory.GetCalorieNeedsCalculator().CalculateCalorieNeeds(patient, Constants.MULTIPLER_FOR_MEDIUM_ACTIVITY);
                        break;
                    case Constants.PHISICAL_ACTIVITY_PRO:
                        calorieNeeds = _factory.GetCalorieNeedsCalculator().CalculateCalorieNeeds(patient, Constants.MULTIPLER_FOR_PRO_ACTIVITY);
                        break;
                    default:
                        Console.WriteLine("man doesnt care :)");
                        break;
                }
            }
            _mailSender.SendMail("You need to eat " + calorieNeeds + "kcal, email with info send to user@gmail.com");
            return calorieNeeds;
        }
    }
}