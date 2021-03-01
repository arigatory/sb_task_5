using System;

namespace sb_task_5_3
{
    class Program
    {
        // Задание 3. Создать метод, принимающий текст. 
        // Результатом работы метода должен быть новый текст, в котором
        // удалены все кратные рядом стоящие символы, оставив по одному 
        // Пример: ПППОООГГГООООДДДААА >>> ПОГОДА
        // Пример: Ххххоооорррооошшшиий деееннннь >>> хороший день
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
