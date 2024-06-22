// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 4: 
// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

System.Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10) System.Console.WriteLine(number);
else
{
    while (number > 0)
    {
        int currentDigit = number % 10;
        number = number / 10;
        if (number > 0)
        {
            System.Console.Write(currentDigit + ",");
        }
        else System.Console.Write(currentDigit);
    }
}

// РЕШЕНИЕ СИСТЕМЫ

// // Задача 4: Вывод цифр числа через запятую
// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите натуральное число N: ");
//         int N = Convert.ToInt32(Console.ReadLine());
//         if (N < 10)
//         {
//             Console.WriteLine(N);
//         }
//         else
//         {
//             while (N > 0)
//             {
//                 int currentDigit = N % 10;
//                 N /= 10;
//                 if (N > 0)
//                 {
//                     Console.Write(currentDigit + ",");
//                 }
//                 else
//                 {
//                     Console.WriteLine(currentDigit);
//                 }
//             }
//         }
//     }
// }