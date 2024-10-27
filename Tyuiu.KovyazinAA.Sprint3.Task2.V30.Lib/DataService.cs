using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KovyazinAA.Sprint3.Task2.V30.Lib
{
    public class DataService : ISprint3Task2V30
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double z = 1;
            do
            {
                z = ((Math.Pow(value,2))*startValue + 2)*z;
                startValue++;
            }while (startValue <= stopValue);
            return Math.Round(z,3);
        }
    }
}
