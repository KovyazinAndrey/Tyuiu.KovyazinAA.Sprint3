using Tyuiu.KovyazinAA.Sprint3.Task4.V3.Lib;
namespace Tyuiu.KovyazinAA.Sprint3.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int str = -5;
            int end = 5;
            double wait = 1.067;
            Assert.AreEqual(wait, ds.Calculate(str, end));
        }
    }
}