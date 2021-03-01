using System;

namespace sb_task_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // *Задание 5
            // Вычислить, используя рекурсию, функцию Аккермана:
            // A(2, 5), A(1, 2)
            // A(n, m) = m + 1, если n = 0,
            //         = A(n - 1, 1), если n <> 0, m = 0,
            //         = A(n - 1, A(n, m - 1)), если n> 0, m > 0.
            // 

            Console.WriteLine($"A(2,2) = {A(2, 2)}");
            Console.WriteLine($"A(2,3) = {A(2, 3)}");
            Console.WriteLine($"A(2,4) = {A(2, 4)}");
            Console.WriteLine($"A(3,2) = {A(3, 2)}");
            Console.WriteLine($"A(3,3) = {A(3, 3)}");
            Console.WriteLine($"A(3,4) = {A(3, 4)}");
            Console.WriteLine($"A(3,5) = {A(3, 5)}");
        }

        static int A(int m, int n)
        {
            if (n<0 || m <0)
            {
                return 0;
            }
            if (m == 0)
            {
                return n + 1;
            }
            if (n == 0)
            {
                return A(m - 1, 1);
            }
            return A(m - 1, A(m, n - 1));
        }
    }
}
