using Logic;
using Logic.Logger;
using MetricConvertLogic;

namespace Converter
{
    public class ConverterService : IConverterService
    {
        public ILogger logger;

        public ConverterService(ILogger log)
        {
            logger = log;
        }


        public double MeterToCentimeter(double value)
        {
            double x = value.MeterToCentimeter();
            logger.Log("MeterToCentimeter", value, x);
            return x;
        }
        public double CentimeterToMeter(double value)
        {
            double x = value.CentimeterToMeter();
            logger.Log("CentimeterToMeter", value, x);
            return x;
        }
        public double CentimeterToMilimeter(double value)
        {
            double x = value.CentimeterToMilimeter();
            logger.Log("CentimeterToMilimeter", value, x);
            return x;
        }
        public double MilimeterToCentimeter(double value)
        {
            double x = value.MilimeterToCentimeter();
            logger.Log("MilimeterToCentimeter", value, x);
            return x;
        }
        public double MeterToInch(double value)
        {
            double x = value.MeterToInch();
            logger.Log("MeterToInch", value, x);
            return x;
        }
        public double InchToMeter(double value)
        {
            double x = value.InchToMeter();
            logger.Log("InchToMeter", value, x);
            return x;
        }
    }
}
