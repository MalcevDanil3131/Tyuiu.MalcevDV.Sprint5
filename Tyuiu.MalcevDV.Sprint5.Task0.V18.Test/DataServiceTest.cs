using Tyuiu.MalcevDV.Sprint5.Task0.V18.Lib;
namespace Tyuiu.MalcevDV.Sprint5.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string result = ds.SaveToFileTextData(3);
            Assert.IsTrue(result.StartsWith(Path.GetTempPath()));
            Assert.IsTrue(File.Exists(result));
        }
    }
}
