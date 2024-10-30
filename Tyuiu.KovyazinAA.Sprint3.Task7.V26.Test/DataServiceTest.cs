using Tyuiu.KovyazinAA.Sprint3.Task7.V26.Lib;
namespace Tyuiu.KovyazinAA.Sprint3.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            int len = end - start + 1;

            double[] waitres;
            waitres = new double[len];

            waitres[0] = 19.81;
            waitres[1] = 16.79;
            waitres[2] = 13.87;
            waitres[3] = 10.98;
            waitres[4] = 7.94;
            waitres[5] = 3.00;
            waitres[6] = 3.23;
            waitres[7] = -0.45;
            waitres[8] = -3.79;
            waitres[9] = -6.97;
            waitres[10] = -10.00;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, end);
            CollectionAssert.AreEqual(waitres, res);
        }
    }
}