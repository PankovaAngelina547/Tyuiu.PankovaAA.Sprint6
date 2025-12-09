using tyuiu.cources.programming.interfaces.Sprint6;
using System;
using System.IO;
using System.Linq;

namespace Tyuiu.PankovaAA.Sprint6.Task7.V11.Lib
{
    public class DataService : ISprint6Task7V11
    {
        public int[,] GetMatrix(string path)
        {
            string[] allLines = File.ReadAllLines(path);

            string[] lines = allLines
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .ToArray();

            if (lines.Length == 0)
                throw new ArgumentException("Файл пустой");

            string[] firstRow = lines[0].Split(';');
            int cols = firstRow.Length;
            int rows = lines.Length;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');

                for (int j = 0; j < cols; j++)
                {
                    if (j < values.Length && int.TryParse(values[j], out int value))
                    {
                        matrix[i, j] = value;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            int fifthRowIndex = 4;
            if (rows > fifthRowIndex)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[fifthRowIndex, j] < 0)
                    {
                        matrix[fifthRowIndex, j] = 9;
                    }
                }
            }

            return matrix;
        }
    }
}