using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Random2Mas(int[,] mas, int n, int m)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = rand.Next(-5, 20);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
        static void SumOfPositive(int[,] masiv, int p, int k)
        {
            int sum = 0;
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (masiv[i, j] >= 0) { sum += masiv[i, j]; }
                    else { sum = -1; break; }

                }
                if (sum == -1)
                {
                    sum = 0;
                    Console.WriteLine("В {0} ряду есть отрицательные числа", i + 1);
                    continue;
                }
                else
                {
                    Console.WriteLine("В {0} ряду сумма елементов, которые не содержит отрицательных чисел равняется {1}", i + 1, sum);
                    sum = 0;
                }
            }
        }
        static void ReplaceMaxAndFirst(int[,] mas, int n, int m)
        {
            Console.WriteLine("Поменяем местами первый из максимальних и первый (технически 0-ой) елементы в каждом рядке предедущей матрицы:");
            for (int i = 0; i < n; i++)
            {
                int max = mas[i, 0];
                int maxindex = 0;
                for (int j = 1; j < m; j++)
                {
                    if (mas[i, j] > max) { max = mas[i, j]; maxindex = j; }
                }
                Swap(ref mas[i, 0], ref mas[i, maxindex]);
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Swap(ref int element1, ref int element2)
        {
            int temp = element1;
            element1 = element2;
            element2 = temp;
        }
        static void Random1Mas(int[] mas, int n)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = rand.Next(-5, 20);
                Console.Write(mas[i] + " ");

            }
            Console.WriteLine();
        }
        static void DeleteEvenElements(int[] mas, int n)
        {
            int k = 0;
            int[] newmas = new int[n / 2];
            for (int i = 1; i < n; i += 2)
            {
                newmas[k] = mas[i];
                Console.Write(newmas[k] + " ");
                k++;
            }
            Console.WriteLine();
        }
        static void RandomJaggedMas(int[][] mas, int n, int m)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    mas[i][j] = rand.Next(-5, 20);
                    Console.Write(mas[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
        public static void DeleteEvenRows(int[][] mas, int n, int m)
        {
            int[][] resizedmas = new int[n / 2][];
            int k = 0;
            for (int i = 1; i < n; i += 2)
            {
                resizedmas[k] = mas[i];
                k++;
            }
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(resizedmas[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите необходимое количество рядков и столбцов цифр в массиве через пробел");
            string[] temp1 = Console.ReadLine().Split();
            int n = Convert.ToInt32(temp1[0]);
            int m = Convert.ToInt32(temp1[1]);
            int[,] mas = new int[n, m];
            Console.WriteLine("Числа в массиве: ");
            Random2Mas(mas, n, m);
            Console.WriteLine("Задание 1");
            SumOfPositive(mas, n, m);

            Console.WriteLine("Задание 2");
            ReplaceMaxAndFirst(mas, n, m);

            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите необходимое количество цифр в новом одновымерном массиве");
            int n2 = int.Parse(Console.ReadLine());
            int[] mas2 = new int[n2];
            Random1Mas(mas2, n2);
            Console.WriteLine("Уничтожим все элементы с парными индексами (индексация с нуля):");
            DeleteEvenElements(mas2, n2);

            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите необходимое количество рядков и столбцов цифр в массиве через пробел");
            string[] temp2 = Console.ReadLine().Split();
            int n3 = Convert.ToInt32(temp2[0]);
            int m3 = Convert.ToInt32(temp2[1]);
            int[][] mas3 = new int[n3][];
            RandomJaggedMas(mas3, n3, m3);
            Console.WriteLine();
            Console.WriteLine("Уничтожим все рядки с парными индексами (индексация с нуля):");
            DeleteEvenRows(mas3, n3, m3);
            Console.ReadKey();

        }
    }
}