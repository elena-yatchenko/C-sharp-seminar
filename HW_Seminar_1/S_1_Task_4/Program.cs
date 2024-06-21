// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// ЗАДАЧА 4
// Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number), 
// а на выходе выводит все чётные числа от 1 до number (включительно), после каждого числа должен быть знак пробела.

// На входе:

// number = 5 
// На выходе:

// 2 4 

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int i = 2;

if (number < i)
{
    System.Console.WriteLine("Введите число больше 1!");
}
else
{
    while (i <= number)
    {
        if (i % 2 == 0)
        {
            System.Console.Write(i + " ");
        }
        i++;
    }
}

// ЕЩЕ ПРОЩЕ ЧЕРЕЗ i += 2
// for (int count = 2; count <= number; count += 2)
//         {
//             Console.Write($"{count} ");
//         }

// // РЕШЕНИЕ системы

// // using System;

// // public class Answer {
// //     static void PrintEvenNumbers(int number)
// //     {
// //         for (int count = 2; count <= number; count += 2)
// //         {
// //             Console.Write($"{count} ");
// //         }
// //     }

// //     static public void Main(string[] args) {
// //         int number;

// //         if (args.Length >= 1) {
// //             number = int.Parse(args[0]);
// //         } else {
// //             number = 6;
// //         }

// //         PrintEvenNumbers(number);
// //     }
// // }
