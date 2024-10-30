using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KovyazinAA.Sprint3.Task7.V26.Lib
{
    public class DataService : ISprint3Task7V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result;
            int len = (stopValue - startValue) + 1;
            result = new double[len];

            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = 5 - 3 * x + ((1 + Math.Sin(x)) / (2 * x - 0.5));

                if ((2 * x - 0.5) == 0) 
                {
                    result[count] = 0.0;
                }
                else
                {
                    result[count] = Math.Round(y,2);
                }
                count++;
            }
            return result;
        }
    }
}
