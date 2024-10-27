using Tyuiu.KovyazinAA.Sprint3.Task2.V30.Lib;
namespace Tyuiu.KovyazinAA.Sprint3.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.25;
            int y = 1;
            int z = 11;
            double wait = 13051.340;
            Assert.AreEqual(wait, ds.GetMultiplySeries(x, y, z));
        }
    }
}