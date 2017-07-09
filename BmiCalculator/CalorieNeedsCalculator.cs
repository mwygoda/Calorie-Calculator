using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace BmiCalculator
{
    public class CalorieNeedsCalculator
    {
        public decimal CalculateCalorieNeeds(decimal bodyWeightOfPatient, string physicalActivityLevel,
            int ageOfPatient, string genderOfPatient, decimal heightOfPatient)
        {

            decimal calorieNeeds = 0;
            if (genderOfPatient == Constants.WOMAN_GENDER)
            {
                if (physicalActivityLevel== Constants.PHISICAL_ACTIVITY_ZERO)
                {
                    Console.WriteLine("email with info send to user@gmail.com");
                    return calorieNeeds = (655m + 9.6m * bodyWeightOfPatient + 1.85m* heightOfPatient - 4.7m * ageOfPatient) * Constants.MULTIPLER_FOR_ZERO_ACTIVITY;
                }
                else if (physicalActivityLevel == Constants.PHISICAL_ACTIVITY_LOW)
                {
                    Console.WriteLine("email with info send to user@gmail.com");
                    return calorieNeeds = (655m + 9.6m * bodyWeightOfPatient + 1.85m* heightOfPatient - 4.7m * ageOfPatient) * Constants.MULTIPLER_FOR_LOW_ACTIVITY;
                }
                
                else if (physicalActivityLevel == Constants.PHISICAL_ACTIVITY_MEDIUM)
                {
                    Console.WriteLine("email with info send to user@gmail.com");
                    return calorieNeeds = (655m + 9.6m * bodyWeightOfPatient + 1.85m* heightOfPatient - 4.7m * ageOfPatient) * Constants.MULTIPLER_FOR_MEDIUM_ACTIVITY;
                }
                else if (physicalActivityLevel == Constants.PHISICAL_ACTIVITY_PRO)
                {
                    Console.WriteLine("email with info send to user@gmail.com");
                    return calorieNeeds = (655m + 9.6m * bodyWeightOfPatient + 1.85m* heightOfPatient - 4.7m * ageOfPatient) * Constants.MULTIPLER_FOR_PRO_ACTIVITY;
                }
            }
            else
            {
                Console.WriteLine("man doesnt care :)");
                return calorieNeeds = 9999999;
            }
            Console.WriteLine("email with info send to user@gmail.com");
            return calorieNeeds;
        }
    }
}