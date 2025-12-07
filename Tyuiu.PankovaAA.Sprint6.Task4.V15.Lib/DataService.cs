using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PankovaAA.Sprint6.Task4.V15.Lib
{
    public class DataService : ISprint6Task4V15
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

        public double CalculateFunction(int x)
        {
            double denominator = 3;

            if (Math.Abs(denominator) < 0.000001)
            {
                return 0;
            }

            double sinPart = Math.Sin(x);
            double fraction = (2 * x) / denominator;
            double cosPart = Math.Cos(x) * 4 * x;

            double result = sinPart + fraction - cosPart;
            return Math.Round(result, 2);
        }
    }
}
