using System;

namespace sb_task_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(removeDuplicates("Heeeello Wooooooooooooooorld!"));
        }

        private static string removeDuplicates(string text)
        {
            char prev = ' ';
            char[] result = new char[text.Length];
            int i = 0;

            foreach (var c in text)
            {
                if (prev != c)
                {
                    result[i] = c;
                    prev = c;
                    i++;
                }
            }
            result = result[..i];
            return String.Join("", result);
        }
    }
}
