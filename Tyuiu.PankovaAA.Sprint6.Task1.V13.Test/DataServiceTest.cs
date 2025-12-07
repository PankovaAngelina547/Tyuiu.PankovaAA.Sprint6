using Tyuiu.PankovaAA.Sprint6.Task1.V13.Lib;
namespace Tyuiu.PankovaAA.Sprint6.Task1.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(0, 0);
            double result = res[0];

            double expected = -8.00;
            Assert.AreEqual(expected, result, 0.01);
        }

        [TestMethod]
        public void TestArraySize()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            Assert.AreEqual(11, res.Length);
        }
    }
}
        
