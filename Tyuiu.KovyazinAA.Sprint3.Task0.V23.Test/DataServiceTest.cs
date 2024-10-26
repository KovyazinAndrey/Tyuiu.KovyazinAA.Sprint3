using Tyuiu.KovyazinAA.Sprint3.Task0.V23.Lib;
namespace Tyuiu.KovyazinAA.Sprint3.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.5;
            int y = 1;
            int z = 10;
            double res = ds.GetSumSeries(x, y, z);
            double wait = 0.298;
            Assert.AreEqual(wait, res);
        }
    }
}