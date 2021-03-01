﻿using System;

namespace sb_task_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1.
            // Воспользовавшись решением задания 3 четвертого модуля
            // 1.1. Создать метод, принимающий число и матрицу, возвращающий матрицу умноженную на число
            // Это MultiplyNumber(A, number)
            // 1.2. Создать метод, принимающий две матрицу, возвращающий их сумму
            // Это Sum(A, B)

            // 1.3. Создать метод, принимающий две матрицу, возвращающий их произведение
            // Это MultiplyJagged(int[][] x, int[][] y)


            int rows;
            int columns;
            int number;

            Console.Write("Введите количество строк: ");
            if (int.TryParse(Console.ReadLine(), out rows))
            {
                rows = rows == 0 ? 10 : Math.Abs(rows);
                Console.WriteLine($"Количество строк будет равно {rows}");
            }
            else
            {
                rows = 10;
                Console.WriteLine($"Введено что-то не то! Для деменстрации количество строк будет равно {rows}");
            }

            Console.Write("\nВведите количество столбцов: ");
            if (int.TryParse(Console.ReadLine(), out columns))
            {
                columns = columns == 0 ? 10 : Math.Abs(columns);
                Console.WriteLine($"Количество колонок будет равно {columns}");
            }
            else
            {
                columns = 10;
                Console.WriteLine($"Введено что-то не то! Для деменстрации количество колонок будет равно {columns}");
            }

            Console.WriteLine("Введите число");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine($"Будем умножать на {number}");
            }
            else
            {
                rows = 10;
                Console.WriteLine($"Введено что-то не то! Будем умножать на {number}");
            }


            int[][] A = CreateJaggedArray(rows, columns);
            Fill(A);
            Console.WriteLine("\n\nУмножаем матрицу:");
            Print(A);
            Console.WriteLine($"На число {number}");
            Console.WriteLine("Результат:");
            Print(MultiplyNumber(A, number));
     

            

            Console.WriteLine("\n\nСкладываем матрицу:");
            Print(A);
            int[][] B = CreateJaggedArray(rows, columns);
            Fill(B);
            Console.WriteLine("С матрицей:");
            Print(B);
            Console.WriteLine("Результат:");
            Print(Sum(A, B));



            

            Console.WriteLine($"\n\nПриступаем к умножению матрицы размера {rows} на {columns}:");
            Console.Write("Введите количество строк для второй матрицы: ");
            
            int rows2;
            int columns2;
            if (int.TryParse(Console.ReadLine(), out rows2))
            {
                rows2 = rows2 == 0 ? 10 : Math.Abs(rows2);
                Console.WriteLine($"Количество строк будет равно {rows2}");
            }
            else
            {
                rows2 = columns;
                Console.WriteLine($"Введено что-то не то! Для деменстрации количество строк будет равно {rows2}");
            }

            Console.Write("\nВведите количество столбцов для второй матрицы: ");
            if (int.TryParse(Console.ReadLine(), out columns2))
            {
                columns2 = columns2 == 0 ? 10 : Math.Abs(columns2);
                Console.WriteLine($"Количество колонок будет равно {columns2}");
            }
            else
            {
                columns2 = 3;
                Console.WriteLine($"Введено что-то не то! Для деменстрации количество колонок будет равно {columns2}");
            }

            Console.WriteLine("\n\nУмножаем матрицу:");
            Print(A);
            B = CreateJaggedArray(rows2, columns2);
            Fill(B);
            Console.WriteLine("На матрицу:");
            Print(B);
            Console.WriteLine("Результат:");
            if (columns == rows2)
            {
                Print(MultiplyJagged(A, B));
            }
            else
            {
                Console.WriteLine("Данные матрицы нельзя перемножить");
            }

        }

        private static int[][] Sum(int[][] x, int[][] y)
        {
            int[][] result = CreateJaggedArray(x.Length, x[0].Length);
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x[i].Length; j++)
                {
                    result[i][j] = x[i][j] + y[i][j];
                }
            }
            return result;
        }

        public static void Print(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write("{0,7}", matrix[i][j]);
                }
                Console.WriteLine();
            }
        }

        public static int[][] MultiplyNumber(int[][] x, int n)
        {
            int[][] result = CreateJaggedArray(x.Length, x[0].Length);
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x[i].Length; j++)
                {
                    result[i][j] = x[i][j] * n;
                }
            }
            return result;
        }

        public static int[][] MultiplyJagged(int[][] x, int[][] y)
        {
            if (x[0].Length != y.Length)
                return null;
            int[][] result = CreateJaggedArray(x.Length, y[0].Length);
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y[0].Length; j++)
                {
                    for (int k = 0; k < x[0].Length; k++)
                    {
                        result[i][j] += x[i][k] * y[k][j];
                    }
                }
            }
            return result;
        }

        public static void Fill(int[][] y)
        {
            Random r = new Random();
            for (int i = 0; i < y.Length; i++)
            {
                for (int j = 0; j < y[i].Length; j++)
                {
                    y[i][j] = r.Next(-10,10);
                }
            }
        }

        public static int[][] CreateJaggedArray(int m, int n)
        {
            int[][] res = new int[m][];
            for (int i = 0; i < m; i++)
            {
                res[i] = new int[n];
            }
            return res;
        }
    }
}
