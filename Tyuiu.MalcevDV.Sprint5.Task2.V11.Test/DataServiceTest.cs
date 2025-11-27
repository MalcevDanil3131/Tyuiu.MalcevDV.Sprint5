using Tyuiu.MalcevDV.Sprint5.Task2.V11.Lib;
namespace Tyuiu.MalcevDV.Sprint5.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int[,] matrix = new int[,]
            {
                { 4, 9, 3 },
                { 5, 8, 8 },
                { 5, 7, 5 }
            };
            string filePath = dataService.SaveToFileTextData(matrix);
            Assert.IsTrue(File.Exists(filePath));
            string[] lines = File.ReadAllLines(filePath);
            Assert.AreEqual(3, lines.Length);
            Assert.AreEqual("4;0;0", lines[0]);
            Assert.AreEqual("0;8;8", lines[1]);
            Assert.AreEqual("0;0;0", lines[2]);


            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}
