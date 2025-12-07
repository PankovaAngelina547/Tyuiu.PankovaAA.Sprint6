using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PankovaAA.Sprint6.Task0.V2.Lib
{
    public class DataService : ISprint6Task0V2
    {
        public double Calculate(int x)
        {
            return Math.Round((2 * x * x - 1) / Math.Sqrt(x * x - 2), 3);
        }
    }
}
