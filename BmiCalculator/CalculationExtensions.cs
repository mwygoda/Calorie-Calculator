namespace BmiCalculator
{
    public static class CalculationExtensions
    {
        public static decimal CalculateCalorieNeeds(Patient patient,
            decimal phisicalMultiplayer)
        {
            return (655m + 9.6m * patient.bodyWeight + 1.85m * patient.height - 4.7m * patient.age) * phisicalMultiplayer;
        }
    }
}
