namespace WebApplicationTEST.CalculatorService.VolumeCalculator
{
    public interface ICalculator
    {
        double CalculateVolumeCylinder(double radius, double height);
        double CalculateVolumeCone(double radius, double height);
    }
}