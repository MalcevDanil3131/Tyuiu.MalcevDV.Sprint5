using Tyuiu.MalcevDV.Sprint5.Task4.V15.Lib;
namespace Tyuiu.MalcevDV.Sprint5.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V15.txt";

            FileInfo file = new FileInfo(path);
            bool fileExists = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
