using Tyuiu.PankovaAA.Sprint6.Task7.V11.Lib;
namespace Tyuiu.PankovaAA.Sprint6.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\temp\TestMatrix.csv";

            string directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string[] lines = new string[]
            {
                "1;2;3;4;5",
                "6;7;8;9;10",
                "-1;-2;-3;-4;-5",
                "11;12;13;14;15",
                "16;-17;18;-19;20",
                "21;22;23;24;25"
            };

            File.WriteAllLines(path, lines);

            int[,] matrix = ds.GetMatrix(path);

            Assert.IsNotNull(matrix);

            Assert.AreEqual(6, matrix.GetLength(0));

            Assert.AreEqual(5, matrix.GetLength(1));

            Assert.AreEqual(1, matrix[0, 0]);
            Assert.AreEqual(-17, matrix[4, 1]);
            Assert.AreEqual(-19, matrix[4, 3]);
            Assert.AreEqual(25, matrix[5, 4]);

            File.Delete(path);

            if (Directory.Exists(directory) && Directory.GetFiles(directory).Length == 0)
            {
                Directory.Delete(directory);
            }
        }
    }
}
    

