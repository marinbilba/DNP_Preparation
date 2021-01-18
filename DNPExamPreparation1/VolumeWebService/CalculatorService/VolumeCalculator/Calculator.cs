using System;

namespace WebApplicationTEST.CalculatorService.VolumeCalculator
{
    public class Calculator :ICalculator
    {
        public double CalculateVolumeCylinder(double radius, double height)
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }
        public double CalculateVolumeCone(double radius, double height)
        {
            return (1.0/3)*Math.PI * Math.Pow(radius, 2) * height;
        }
    }
}