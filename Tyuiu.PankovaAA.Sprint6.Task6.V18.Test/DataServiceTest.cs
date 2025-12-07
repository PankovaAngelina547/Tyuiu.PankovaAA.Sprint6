using Tyuiu.PankovaAA.Sprint6.Task6.V18.Lib;
namespace Tyuiu.PankovaAA.Sprint6.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string testData = "gMxnli NEzHYMM clishl VAYYbnhDwIg\n" +
                             "cqqToIKFd OmduE fGf m DdygjSJAIQx\n" +
                             "03QBG etujsEyNkkCsy bBYQQ TUczey\n" +
                             "NtFbXoZ slmk pmYGtO CMmHkUlnNoZen\n" +
                             "rvzAEwiXzIsLRa MqU xakZKciG nqrB";

            string tempPath = Path.GetTempFileName();
            File.WriteAllText(tempPath, testData, System.Text.Encoding.Default);

            DataService ds = new DataService();
            string res = ds.CollectTextFromFile(tempPath);
            string wait = "gMxnli VAYYbnhDwIg etujsEyNkkCsy NtFbXoZ CMmHkUlnNoZen rvzAEwiXzIsLRa xakZKciG";

            Assert.AreEqual(wait, res);

            File.Delete(tempPath);
        }
    }
}
