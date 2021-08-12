using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface IConverterService
    {
        public double MeterToCentimeter(double value);
        public double CentimeterToMeter(double value);
        public double CentimeterToMilimeter(double value);
        public double MilimeterToCentimeter(double value);
        public double MeterToInch(double value);
        public double InchToMeter(double value);
    }
}
