// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 3: 
// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

System.Console.Write("Введите число от 10 до 99: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10 && number <= 99)
{
    int num1 = number / 10;
    int num2 = number % 10;
    int max = num1;
    if (num2 > max) max = num2;
    System.Console.WriteLine(max);
}
else System.Console.WriteLine("Вы ввели некорректное число!");

// //python
// number = input("Введите число от 10 до 99: ")
// if 10 <= number <= 99:
//     num1 = number//10
//     num2 = number % 10
//     max = num1
//     if num2 > max:
//         max = num2
//     print(max)
// else:
//     print("Некорректное число!")

// РЕШЕНИЕ СИСТЕМЫ

// Задача 3: Показ наибольшей цифры числа
// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите число из отрезка [10, 99]: ");
//         int number = Convert.ToInt32(Console.ReadLine());
//         int firstDigit = number / 10;
//         int secondDigit = number % 10;
//         int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; Console.WriteLine(maxDigit);
//     }
// }