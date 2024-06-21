// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// ЗАДАЧА 3

// Напишите программу, которая на вход принимает число number и 
// выводит, является ли число чётным (делится ли оно на два без остатка).

// Пример использования:
// На входе:

// number: '6'
// На выходе:

// четное

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    System.Console.WriteLine("четное");
}
else
{
    System.Console.WriteLine("нечетное");
}

// // РЕШЕНИЕ СИСТЕМЫ

// using System;

// class Answer {
//     static void CheckIfEven(int number)
//     {
//         if ((number % 2) == 0)
//         {
//             Console.WriteLine($"четное");
//         }
//         else
//         {
//             Console.WriteLine($"нечетное");
//         }
//     }

//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//             number = 6;
//         }

//         CheckIfEven(number);
//     }
// }
