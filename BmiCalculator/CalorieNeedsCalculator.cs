using System;
using System.Security.Cryptography;

namespace BmiCalculator
{
    public class CalorieNeedsCalculator
    {
        public decimal CalculateCalorieNeeds(decimal bodyWeightOfPatient, string physicalActivityLevel,
            int ageOfPatient, string genderOfPatient, decimal heightOfPatient)
        {
            decimal calorieNeeds = 0;
            if (genderOfPatient == "woman")
            {
                if (physicalActivityLevel== "zero")
                {
                    return calorieNeeds = (655m + 9.6m * bodyWeightOfPatient + 1.85m* heightOfPatient - 4.7m * ageOfPatient) * 1.0m;
                }
                else if (physicalActivityLevel == "twoTimesWeek")
                {
                    return calorieNeeds = (655m + 9.6m * bodyWeightOfPatient + 1.85m* heightOfPatient - 4.7m * ageOfPatient) * 1.2m;
                }
                
                else if (physicalActivityLevel == "fourTimesWeek")
                {
                    return calorieNeeds = (655m + 9.6m * bodyWeightOfPatient + 1.85m* heightOfPatient - 4.7m * ageOfPatient) * 1.5m;
                }
                else if (physicalActivityLevel == "everyday")
                {
                    return calorieNeeds = (655m + 9.6m * bodyWeightOfPatient + 1.85m* heightOfPatient - 4.7m * ageOfPatient) * 2.0m;
                }
            }
            else
            {
                Console.WriteLine("man doesnt care :)");
                return calorieNeeds = 9999999;
            }
            return calorieNeeds;
        }
    }
}