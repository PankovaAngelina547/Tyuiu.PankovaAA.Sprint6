using Tyuiu.PankovaAA.Sprint6.Task4.V15.Lib;
namespace Tyuiu.PankovaAA.Sprint6.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            double[] wait = {
                -17.79,
                -10.56,
                -3.23,
                1.24,
                4.02,
                0,
                -1.98,
                0.24,
                5.77,
                10.56,
                17.79
            };

            CollectionAssert.AreEqual(wait, result);
        }
    }
}
