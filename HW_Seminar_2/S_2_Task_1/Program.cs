// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 1: 
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

System.Console.Write("Введите число для проверки: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 || number % 23 == 0)
{
    System.Console.WriteLine("yes");
}
else System.Console.WriteLine("no");

// РЕШЕНИЕ СИСТЕМЫ

// // Задача 1: Проверка кратности числа 7 и 23
// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите число a: ");
//         int a = Convert.ToInt32(Console.ReadLine());
//         if (a % 7 == 0 && a % 23 == 0)
//         {
//             Console.WriteLine("да");
//         }
//         else
//         {
//             Console.WriteLine("нет");
//         }
//     }
// }