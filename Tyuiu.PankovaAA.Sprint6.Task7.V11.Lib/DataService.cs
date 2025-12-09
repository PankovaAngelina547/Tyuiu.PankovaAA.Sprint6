using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PankovaAA.Sprint6.Task7.V11.Lib

    {
        public interface ISprint6Task7V11
        {
            int[,] GetMatrix(string path);
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

                    string[] firstLineValues = lines[0].Split(new char[] { ';', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    int cols = firstLineValues.Length;
                    int rows = lines.Length;

                    int[,] matrix = new int[rows, cols];

                    for (int i = 0; i < rows; i++)
                    {
                        string[] values = lines[i].Split(new char[] { ';', ',' }, StringSplitOptions.RemoveEmptyEntries);

                        if (values.Length != cols)
                        {
                            
                            if (values.Length < cols)
                            {
                                string[] newValues = new string[cols];
                                Array.Copy(values, newValues, values.Length);
                                for (int k = values.Length; k < cols; k++)
                                {
                                    newValues[k] = "0";
                                }
                                values = newValues;
                            }
                            else
                            {
                               
                                values = values.Take(cols).ToArray();
                            }
                        }

                        for (int j = 0; j < cols; j++)
                        {
                    
                            string cleanValue = values[j].Trim();

                            if (string.IsNullOrEmpty(cleanValue))
                            {
                                matrix[i, j] = 0; 
                            }
                            else if (int.TryParse(cleanValue, out int value))
                            {
                                matrix[i, j] = value;
                            }
                            else
                            {
                                
                                if (double.TryParse(cleanValue, out double doubleValue))
                                {
                                    matrix[i, j] = (int)Math.Round(doubleValue);
                                }
                                else
                                {
                                    throw new FormatException($"Неверный формат данных в строке {i + 1}, столбце {j + 1}: '{cleanValue}'");
                                }
                            }
                        }
                    }

                    return matrix;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ошибка при чтении файла '{Path.GetFileName(path)}': {ex.Message}", ex);
                }
            }
        }
    }
