namespace BmiCalculator
{
    public static class Constants
    {
        public const string WOMAN_GENDER = "woman";
        public const string MAN_GENDER = "man";
        public const string PHISICAL_ACTIVITY_ZERO = "zero";
        public const string PHISICAL_ACTIVITY_LOW = "twoTimesWeek";
        public const string PHISICAL_ACTIVITY_MEDIUM = "fourTimesWeek";
        public const string PHISICAL_ACTIVITY_PRO = "everyday";
        
        public const decimal MULTIPLER_FOR_ZERO_ACTIVITY = 1.0m;
        public const decimal MULTIPLER_FOR_LOW_ACTIVITY = 1.2m;
        public const decimal MULTIPLER_FOR_MEDIUM_ACTIVITY = 1.5m;
        public const decimal MULTIPLER_FOR_PRO_ACTIVITY = 2.0m;
    }
}