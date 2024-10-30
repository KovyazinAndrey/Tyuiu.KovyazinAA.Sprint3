using Tyuiu.KovyazinAA.Sprint3.Task6.V11.Lib;
namespace Tyuiu.KovyazinAA.Sprint3.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = 10;
            int end = 19;
            int wait = 9;
            Assert.AreEqual(wait, ds.GetSumTheDivisors(start, end));
        }
    }
}