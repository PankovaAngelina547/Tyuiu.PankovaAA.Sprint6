using Tyuiu.PankovaAA.Sprint6.Task3.V26.Lib;
namespace Tyuiu.PankovaAA.Sprint6.Task3.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();


            int[,] matrix = new int[5, 5]
            {
                { 16,  19,  17,   2,   8 },
                {-17,   8, -17,  -8,   1 },
                { -7,  17,  -2,   1,  -3 },
                {-12,   0, -17,  15,   6 },
                { 17,  -6, -17,  18, -19 }
            };

            int[,] waitMatrix = new int[5, 5]
            {
                { 16,  19,  17,   2,   8 },
                {-17,   8, -17,  -8,   1 },
                { -7,  17,   0,   1,  -3 },  
                {-12,   0, -17,  15,   6 },
                { 17,  -6, -17,  18, -19 }
            };

            int[,] resultMatrix = ds.Calculate(matrix);
            bool areEqual = true;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (resultMatrix[i, j] != waitMatrix[i, j])
                    {
                        areEqual = false;
                        break;
                    }
                }
            }

            Assert.IsTrue(areEqual);
        }
    }
}
