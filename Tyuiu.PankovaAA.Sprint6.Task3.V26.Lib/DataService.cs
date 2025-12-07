using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PankovaAA.Sprint6.Task3.V26.Lib
{
    public class DataService : ISprint6Task3V26
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[,] resultMatrix = (int[,])matrix.Clone();

            int rowIndex = 2; 

            for (int j = 0; j < columns; j++)
            {
                if (resultMatrix[rowIndex, j] % 2 == 0)
                {
                    resultMatrix[rowIndex, j] = 0;
                }
            }

            return resultMatrix;
        }
    }
}