using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KovyazinAA.Sprint3.Task0.V23.Lib
{
    public class DataService : ISprint3Task0V23
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double z = 0;
            for (int k = startValue; k <= stopValue; k++)
            {
                z = Math.Pow(1 / (Math.Sin(k) + (2 * (Math.Pow(value, k)))),k) + z;
            }
            return Math.Round(z,3);
        }
    }
}
