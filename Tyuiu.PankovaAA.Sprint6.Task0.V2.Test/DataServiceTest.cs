using Tyuiu.PankovaAA.Sprint6.Task0.V2.Lib;
namespace Tyuiu.PankovaAA.Sprint6.Task0.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            double expected = 6.425;
            double actual = ds.Calculate(x);
            Assert.AreEqual(expected, actual, 0.001);
        }

    }
}
