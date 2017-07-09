namespace BmiCalculator
{
    public interface ICalorieNeedsCalculator
    {
        decimal CalculateCalorieNeeds(Patient patient,decimal phisicalMultiplayer);
    }
}