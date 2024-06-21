// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// ЗАДАЧА 2
// Внутри класса Answer напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.Write("First number: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Second number: ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Third number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

System.Console.WriteLine(max);

// // РЕШЕНИЕ системы
// // using System;

// // public class Answer {
// //     static int FindMax(int a, int b, int c)
// //     {
// //       int max = a;
// //         if (max < b)
// //         {
// //             max = b;
// //         }
// //         if (max < c)
// //         {
// //             max = c;
// //         }
// //         return max;
// //     }

// //     static public void Main(string[] args) {
// //         int a, b, c;

// //         if (args.Length >= 3) {
// //             a = int.Parse(args[0]);
// //             b = int.Parse(args[1]);
// //             c = int.Parse(args[2]);
// //         } else {
// //             a = 5;
// //             b = 6;
// //             c = 7;
// //         }

// //         int result = FindMax(a, b, c);
// //         System.Console.WriteLine($"{result}");
// //     }
// // }
