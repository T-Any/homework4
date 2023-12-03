// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


using System;

class Program
{
    static void Main()
    {
        // Создаю массив случайных трехзначных чисел
        int[] randomNumbers = GenerateRandomNumbers(10);

        // Вывожу элементы массива
        Console.WriteLine("Сгенерированный массив случайных трехзначных чисел:");
        PrintArray(randomNumbers);

        // Подсчитываю количество четных чисел
        int evenCount = CountEvenNumbers(randomNumbers);

        // Вывожу результат
        Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
    }

    static int[] GenerateRandomNumbers(int count)
    {
        Random random = new Random();
        int[] numbers = new int[count];

        for (int i = 0; i < count; i++)
        {
            numbers[i] = random.Next(100, 1000); // Генерирую трехзначные числа
        }

        return numbers;
    }

    static void PrintArray(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }

    static int CountEvenNumbers(int[] array)
    {
        int evenCount = 0;

        foreach (var number in array)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        return evenCount;
    }
}
