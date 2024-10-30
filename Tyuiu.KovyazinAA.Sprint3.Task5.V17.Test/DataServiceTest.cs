using Tyuiu.KovyazinAA.Sprint3.Task5.V17.Lib;
namespace Tyuiu.KovyazinAA.Sprint3.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            int i = 1;
            int i2 = 3;
            int j = 1;
            int j2 = 12;
            double wait = 143.624;
            Assert.AreEqual(wait, ds.GetSumSumSeries(x, i, j, i2, j2));
        }
    }
}