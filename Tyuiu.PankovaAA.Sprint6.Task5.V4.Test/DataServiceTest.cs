using Tyuiu.PankovaAA.Sprint6.Task5.V4.Lib;
namespace Tyuiu.PankovaAA.Sprint6.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string testData = @"-1
2,5
3
-1
-2,6
-3
0
5,7
-5
6
-6,8
7
-7
8
-8
9,9
-9
10
-10
0";

            string tempPath = Path.GetTempFileName();
            File.WriteAllText(tempPath, testData);

            DataService ds = new DataService();
            double[] res = ds.LoadFromDataFile(tempPath);

            double[] wait = { -1, 3, -1, -3, 0, -5, 6, 7, -7, 8, -8, -9, 10, -10, 0 };

            CollectionAssert.AreEqual(wait, res);

            File.Delete(tempPath);
        }
    }
}
