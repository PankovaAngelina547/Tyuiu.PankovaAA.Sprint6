using tyuiu.cources.programming.interfaces.Sprint6;
using System;
using System.IO;
using System.Linq;

namespace Tyuiu.PankovaAA.Sprint6.Task7.V11.Lib
{
    public interface ISprint6Task7V11
    {
        int[,] GetMatrix(string path);
        void TransformAndSave(string pathIn, string pathOut);
    }

    public class DataService : ISprint6Task7V11
    {
        public int[,] GetMatrix(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                lines = lines.Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();

                if (lines.Length == 0)
                {
                    throw new ArgumentException("Файл пустой");
                }

                string[] firstLineValues = lines[0].Split(';');
                int cols = firstLineValues.Length;
                int rows = lines.Length;

                int[,] matrix = new int[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    string[] values = lines[i].Split(';');

                    if (values.Length != cols)
                    {
                        throw new FormatException($"Несоответствие количества столбцов в строке {i + 1}");
                    }

                    for (int j = 0; j < cols; j++)
                    {
                        if (int.TryParse(values[j], out int value))
                        {
                            matrix[i, j] = value;
                        }
                        else
                        {
                            matrix[i, j] = 0;
                        }
                    }
                }

                return matrix;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при чтении файла: {ex.Message}", ex);
            }
        }

        public void TransformAndSave(string pathIn, string pathOut)
        {
            try
            {
            
                int[,] matrix = GetMatrix(pathIn);
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                
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

            
                using (StreamWriter sw = new StreamWriter(pathOut))
                {
                    for (int i = 0; i < rows; i++)
                    {
                        string[] rowValues = new string[cols];
                        for (int j = 0; j < cols; j++)
                        {
                            rowValues[j] = matrix[i, j].ToString();
                        }
                        sw.WriteLine(string.Join(";", rowValues));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при преобразовании и сохранении: {ex.Message}", ex);
            }
        }
    }
}