// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целые числа. Для завершения введите 'q' или число с чётной суммой цифр.");

        while (true)
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine()!;

            if (input.ToLower() == "q")
            {
                Console.WriteLine("Программа завершена по запросу пользователя.");
                break;
            }

            if (IsEvenDigitSum(int.Parse(input)))
            {
                Console.WriteLine($"Программа завершена. Сумма цифр введённого числа чётная.");
                break;
            }
        }
    }

    static bool IsEvenDigitSum(int number)
    {
        int digitSum = 0;

        while (number > 0)
        {
            digitSum += number % 10;
            number /= 10;
        }

        return digitSum % 2 == 0;
    }
}

