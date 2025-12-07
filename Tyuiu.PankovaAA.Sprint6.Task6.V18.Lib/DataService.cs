using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PankovaAA.Sprint6.Task6.V18.Lib
{
    public class DataService : ISprint6Task6V18
    {
        public string CollectTextFromFile(string path)
        {
            if (!File.Exists(path))
                return "Файл не найден";

            try
            {
                string text = File.ReadAllText(path, Encoding.Default);
                string[] separators = { " ", "\r", "\n", "\t", ",", ".", "!", "?", ";", ":", "(", ")", "[", "]", "{", "}", "\"", "'" };
                string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                StringBuilder result = new StringBuilder();

                foreach (string word in words)
                {
                    if (word.Contains('n'))
                    {
                        result.Append(word + " ");
                    }
                }

                return result.ToString().Trim();
            }
            catch
            {
                return "Ошибка чтения файла";
            }
        }
    }
}