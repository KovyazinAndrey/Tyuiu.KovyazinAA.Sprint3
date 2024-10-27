using Tyuiu.KovyazinAA.Sprint3.Task1.V9.Lib;
namespace Tyuiu.KovyazinAA.Sprint3.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int strvl = 1;
            int spvl = 4;
            double wait = 211.349;
            Assert.AreEqual(wait, ds.GetMultiplySeries(x, strvl, spvl));
        }
    }
}