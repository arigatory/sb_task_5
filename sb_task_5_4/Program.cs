using System;
using System.Linq;

namespace sb_task_5_4
{
    class Program
    {
        // Задание 4. Написать метод принимающий некоторое количесво чисел, выяснить
        // является заданная последовательность элементами арифметической или геометрической прогрессии
        // 
        // Примечание
        //             http://ru.wikipedia.org/wiki/Арифметическая_прогрессия
        //             http://ru.wikipedia.org/wiki/Геометрическая_прогрессия
        //
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность чисел через пробел");
            string[] numbersInString = Console.ReadLine().Split();
            int[] numbers = numbersInString.Select(n => int.Parse(n)).ToArray();
            if (numbers.Length < 2)
            {
                Console.WriteLine("Введено что-то не то, либо мало чисел. Завершение работы");
                return;
            }
            if (checkAriphmetic(numbers))
            {
                Console.WriteLine("Данные числа составляют арифметическую прогрессию");
            }
            if (checkGeometric(numbers))
            {
                Console.WriteLine("Данные числа составляют геометрическую прогрессию");
            }
        }

        static bool checkAriphmetic(int[] numbers)
        {
            if (numbers.Length < 2)
            {
                return false;
            }
            bool result = true;
            for (int i = 1; i < numbers.Length; i++)
            {
                result = result && numbers[1] - numbers[0] == numbers[i] - numbers[i - 1];
            }
            return result;
        }

        static bool checkGeometric(int[] numbers)
        {
            if (numbers.Length < 2)
            {
                return false;
            }
            bool result = true;
            for (int i = 1; i < numbers.Length; i++)
            {
                result = result && numbers[1] / numbers[0] == numbers[i] / numbers[i - 1];
            }
            return result;
        }
    }
}
