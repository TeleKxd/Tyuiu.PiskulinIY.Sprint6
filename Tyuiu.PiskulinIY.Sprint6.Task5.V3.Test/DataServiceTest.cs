using System.IO;
using Tyuiu.PiskulinIY.Sprint6.Task5.V3.Lib;
namespace Tyuiu.PiskulinIY.Sprint6.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\AeroC\source\repos\Tyuiu.PiskulinIY.Sprint6\Tyuiu.PiskulinIY.Sprint6.Task5.V3\bin\Debug\net8.0-windows\InPutFileTask5v3.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}