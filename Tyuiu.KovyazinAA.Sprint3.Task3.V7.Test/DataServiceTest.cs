using Tyuiu.KovyazinAA.Sprint3.Task3.V7.Lib;
namespace Tyuiu.KovyazinAA.Sprint3.Task3.V7.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string val = "gft hggt ntg";
            char replacement = 'g';
            char replacing = '4';
            string wait = "4ft h44t nt4";
            Assert.AreEqual(wait,ds.ReplaceCharOnNum(val, replacement, replacing));
        }
    }
}