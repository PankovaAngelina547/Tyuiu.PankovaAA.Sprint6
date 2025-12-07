using Tyuiu.PankovaAA.Sprint6.Task2.V18.Lib;
namespace Tyuiu.PankovaAA.Sprint6.Task2.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-5, 5);

            Assert.AreEqual(11, result.Length);
        }
    }
}

