using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PankovaAA.Sprint6.Task5.V4.Lib
{
    public class DataService : ISprint6Task5V4
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            double[] numbers = new double[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Replace(',', '.');
                if (double.TryParse(lines[i], System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out double num))
                {
                    numbers[i] = Math.Round(num, 3);
                }
                else
                {
                    numbers[i] = 0;
                }
            }

            double[] allIntegers = new double[0];
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (Math.Abs(numbers[i] - Math.Round(numbers[i])) < 0.001)
                {
                    Array.Resize(ref allIntegers, count + 1);
                    allIntegers[count] = Math.Round(numbers[i]);
                    count++;
                }
            }

            return allIntegers;
        }
    }
}