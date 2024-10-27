using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KovyazinAA.Sprint3.Task1.V9.Lib
{
    public class DataService : ISprint3Task1V9
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double z = 0;
            while (startValue <= stopValue)
            {
                z = Math.Pow(300.0 / (Math.Cos(value) + Math.Pow(value, startValue)), startValue) + z;
                startValue++;
            }
            return Math.Round(z, 3);
        }
    }
}
