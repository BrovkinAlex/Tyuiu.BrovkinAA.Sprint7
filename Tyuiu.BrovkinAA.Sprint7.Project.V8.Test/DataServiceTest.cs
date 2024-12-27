using Tyuiu.BrovkinAA.Sprint7.Project.V8.Lib;
namespace Tyuiu.BrovkinAA.Sprint7.Project.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromFile()
        {
            DataService ds = new DataService();
            string[,] loadData = ds.LoadDataFromFile(Path.Combine(Directory.GetCurrentDirectory(), "text1.csv"));
            string[,] wait =
            {
                { "1", "awd", "_awdaass", "zxczx", "124sefe", "**(((*" },
                { "1", "2", "3", "3", "4", "5" },
                { "6", "5", "4", "3", "2", "1" },
                { "ada", "zc", "gkj", "d5", "3r", "5642352525" }
            };

            CollectionAssert.AreEqual(wait, loadData);
        }
    }
}
