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
                switch (physicalActivityLevel)
                {
                    case Constants.PHISICAL_ACTIVITY_ZERO:
                        calorieNeeds =
                            (655m + 9.6m * bodyWeightOfPatient + 1.85m * heightOfPatient - 4.7m * ageOfPatient) *
                            Constants.MULTIPLER_FOR_ZERO_ACTIVITY;
                        break;
                    case Constants.PHISICAL_ACTIVITY_LOW:
                        calorieNeeds =
                            (655m + 9.6m * bodyWeightOfPatient + 1.85m * heightOfPatient - 4.7m * ageOfPatient) *
                            Constants.MULTIPLER_FOR_LOW_ACTIVITY;
                        break;
                    case Constants.PHISICAL_ACTIVITY_MEDIUM:
                        calorieNeeds =
                            (655m + 9.6m * bodyWeightOfPatient + 1.85m * heightOfPatient - 4.7m * ageOfPatient) *
                            Constants.MULTIPLER_FOR_MEDIUM_ACTIVITY;
                        break;
                    case Constants.PHISICAL_ACTIVITY_PRO:
                        calorieNeeds =
                            (655m + 9.6m * bodyWeightOfPatient + 1.85m * heightOfPatient - 4.7m * ageOfPatient) *
                            Constants.MULTIPLER_FOR_PRO_ACTIVITY;
                        break;
                    default:
                        Console.WriteLine("man doesnt care :)");
                        break;
                }
            }
            Console.WriteLine("email with info send to user@gmail.com");
            return calorieNeeds;
        }
    }
}