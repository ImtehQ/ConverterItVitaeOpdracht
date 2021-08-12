namespace MetricConvertLogic
{
    public static class MetricConvert
    {
        public static double MeterToCentimeter(this double value)
        {
            return value * 100f;
        }
        public static double CentimeterToMeter(this double value)
        {
            return value * 0.01f;
        }
        public static double CentimeterToMilimeter(this double value)
        {
            return value * 100f;
        }
        public static double MilimeterToCentimeter(this double value)
        {
            return value / 100f;
        }
        public static double MeterToInch(this double value)
        {
            return value * 39.3700787f;
        }
        public static double InchToMeter(this double value)
        {
            return value * 0.0254f;
        }
    }
}
