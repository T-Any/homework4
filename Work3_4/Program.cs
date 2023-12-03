// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

using System;

class Program
{
    static void Main()
    {
        // Создаю массив целых чисел
        int[] array = { 1, 2, 3, 4, 5 };

        // Вывожу исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Переворачиваю массив
        ReverseArray(array);

        // Вывожу перевернутый массив
        Console.WriteLine("Перевернутый массив:");
        PrintArray(array);
    }

    static void ReverseArray(int[] array)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left < right)
        {
            // Обмен значениями между left и right
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;

            // Переход к следующим элементам
            left++;
            right--;
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }
}
