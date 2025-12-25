using Tyuiu.MalcevDV.Sprint5.Task7.V20.Lib;
namespace Tyuiu.MalcevDV.Sprint5.Task7.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual("Словарные слова с удвоенной согласной нн", ds.LoadDataAndSave(Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V20.txt")));
        }
    }
}
