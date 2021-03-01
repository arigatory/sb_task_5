using System;
using System.Linq;

namespace sb_task_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 2.
            // 1. Создать метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв
            // 2.* Создать метод, принимающий  текст и возвращающий слово(слова) с максимальным количеством букв 
            // Примечание: слова в тексте могут быть разделены символами (пробелом, точкой, запятой) 
            // Пример: Текст: "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ"
            // 1. Ответ: А
            // 2. ГГГГ, ДДДД        }

            Console.WriteLine(ShortestWord());

            Console.Write(String.Join(", ",LongestWords()));

        }

        static string ShortestWord(string input = "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ")
        {
            var result = input.Split(new string[] { " ", ",", "!" }, StringSplitOptions.RemoveEmptyEntries);
            return result.OrderBy(s => s.Length).FirstOrDefault();
        }

        static string[] LongestWords(string input = "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ")
        {
            var result = input.Split(new string[] { " ", ",", "!" }, StringSplitOptions.RemoveEmptyEntries);
            var longestWords = result.GroupBy(s => s.Length).Last().ToArray();
            return longestWords;
        }
    }
}
