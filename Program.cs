using System;

namespace Troll
{
    internal class Program
    {
        static string Clining(string comment)
        {
            string vowels = "аёуеэоыяиюЁУЕЭОАЫЯИЮ";
            string newcom = string.Empty;
            int count = 0;
            for (int j = 0; j < comment.Length; j++)
            {
                count = 0;

                for (int i = 0; i < vowels.Length; i++)
                {
                    if (vowels[i] == comment[j])
                        count = 1;

                }
                if (count == 0)
                    newcom = newcom + comment[j];
            }
            return newcom;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Жду комментарий, троль!");
            Console.WriteLine("А что ты на это скажешь?" + Environment.NewLine + Clining(Console.ReadLine()));
        }
    }
}