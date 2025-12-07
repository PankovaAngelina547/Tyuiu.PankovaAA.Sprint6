using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PankovaAA.Sprint6.Task1.V13.Lib
{
    public class DataService : ISprint6Task1V13
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

            double numerator = 3 * Math.Cos(x);
            double fraction = numerator / denominator;
            double sinPart = Math.Sin(x);
            double linearPart = -5 * x - 2;

            double result = fraction + sinPart + linearPart;
            return Math.Round(result, 2);
        }
    }
}


