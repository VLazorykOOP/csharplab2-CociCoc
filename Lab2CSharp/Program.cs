using System;

namespace Lab2CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вправа 1: Lab 2 CSharp");

            Console.WriteLine("Введіть розмірність масиву:");
            int size = int.Parse(Console.ReadLine());

            // Одновимірний масив
            int[] array1D = new int[size];
            Console.WriteLine("Введіть елементи масиву:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Елемент {i}: ");
                array1D[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введіть інтервал (мінімальне значення):");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть інтервал (максимальне значення):");
            int max = int.Parse(Console.ReadLine());

            Console.WriteLine("Елементи, що не потрапляють в заданий інтервал (одновимірний масив):");
            for (int i = 0; i < size; i++)
            {
                if (array1D[i] < min || array1D[i] > max)
                {
                    Console.WriteLine($"Елемент {i}: {array1D[i]}");
                }
            }

            // Двовимірний масив
            int[,] array2D = new int[size, size]; // Розмірність двовимірного масиву така ж, як одновимірного

            Console.WriteLine("Введіть елементи двовимірного масиву:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"Елемент [{i},{j}]: ");
                    array2D[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Елементи, що не потрапляють в заданий інтервал (двовимірний масив):");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (array2D[i, j] < min || array2D[i, j] > max)
                    {
                        Console.WriteLine($"Елемент [{i},{j}]: {array2D[i, j]}");
                    }
                }
            }

            Console.WriteLine("\nВправа 2: Lab 2 CSharp");

            Console.WriteLine("Введіть розмірність масиву (Вправа 2):");
            int sizeExercise2 = int.Parse(Console.ReadLine());

            // Одновимірний масив для Вправи 2
            int[] arrayExercise2 = new int[sizeExercise2];
            Console.WriteLine("Введіть елементи масиву для Вправи 2:");
            for (int i = 0; i < sizeExercise2; i++)
            {
                Console.Write($"Елемент {i}: ");
                arrayExercise2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введіть число для порівняння (Вправа 2):");
            double targetDifference = double.Parse(Console.ReadLine());

            // Пошук кількості пар для Вправи 2
            int countPairs = 0;
            for (int i = 0; i < sizeExercise2 - 1; i++)
            {
                if (Math.Abs(arrayExercise2[i] - arrayExercise2[i + 1]) == targetDifference)
                {
                    countPairs++;
                }
            }

            Console.WriteLine($"Кількість пар сусідніх елементів з різницею {targetDifference} (Вправа 2): {countPairs}");
        }
    }
}
