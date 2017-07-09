namespace BmiCalculator
{
    public class CalorieNeedsCalculatorFactory:ICalorieNeedsCalculatorFactory
    {
        private ICalorieNeedsCalculator calculator;
        public ICalorieNeedsCalculator GetCalorieNeedsCalculator()
        {
            return calculator = new ActivityCalorieNeedsCalculator();
        }
    }
}