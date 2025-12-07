using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PankovaAA.Sprint6.Task6.V18.Lib
{
    public class DataService : ISprint6Task6V18
    {
        public string CollectTextFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path, Encoding.Default);
            StringBuilder result = new StringBuilder();

            foreach (string line in lines)
            {
                string[] words = line.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '\t' },
                                           StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    if (word.IndexOf('n', StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        result.Append(word + " ");
                    }
                }
            }

            return result.ToString().Trim();
        }
    }
}
