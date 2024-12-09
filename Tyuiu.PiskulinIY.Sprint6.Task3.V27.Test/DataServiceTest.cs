using Tyuiu.PiskulinIY.Sprint6.Task3.V27.Lib;
namespace Tyuiu.PiskulinIY.Sprint6.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mx = { { 9, 13, -14, 23, -12 },
                          { 15, -17, 21, 25, 1 },
                          { -4, 29, -20, -10, 3 },
                          { 27, 33, 12, 33, 14 },
                          { 18, -9, -5, 6, 23 } };
            int[,] res = ds.Calculate(mx);
            int rows = 5;
            int col = 5;
            int[,] wait = {{ 9, 13, -14, -10, -12 },
                           { 15, -17, 21, 6, 1 },
                           { -4, 29, -20, 23, 3 },
                           { 27, 33, 12, 25, 14 },
                           { 18, -9, -5, 33, 23 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}