namespace BmiCalculator
{
    public class ActivityCalorieNeedsCalculator:ICalorieNeedsCalculator
    {
        public decimal CalculateCalorieNeeds(Patient patient, decimal phisicalMultiplayer)
        {
            return (655m + 9.6m * patient.bodyWeight + 1.85m * patient.height - 4.7m * patient.age) * phisicalMultiplayer;
        }
    }
}