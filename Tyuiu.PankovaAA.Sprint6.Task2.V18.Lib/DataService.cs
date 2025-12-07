using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PankovaAA.Sprint6.Task2.V18.Lib
{
    public class DataService : ISprint6Task2V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int size = stopValue - startValue + 1;
            double[] result = new double[size];

            for (int i = 0; i < size; i++)
            {
                int x = startValue + i;
                result[i] = CalculateFunction(x);
            }

            return result;
        }

        private double CalculateFunction(int x)
        {
            double denominator = 4 * x - 0.5;

            if (Math.Abs(denominator) < 0.000001)
            {
                return 0;
            }

            double result = (3 * Math.Cos(x)) / denominator + Math.Sin(x) - 5 * x - 2;
            return Math.Round(result, 2);
        }
    }
}
    