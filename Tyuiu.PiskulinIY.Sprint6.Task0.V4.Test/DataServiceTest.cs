using Tyuiu.PiskulinIY.Sprint6.Task0.V4;
using Tyuiu.PiskulinIY.Sprint6.Task0.V4.Lib;
namespace Tyuiu.PiskulinIY.Sprint6.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = 68.3;
            Assert.AreEqual(wait, res);

        }
    }
}