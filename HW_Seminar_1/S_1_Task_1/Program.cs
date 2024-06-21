// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Задача 1
// Напишите программу, которая на вход принимает два числа и выводит, 
// какое число большее, а какое меньшее.

// Пример использования:
// На входе:
// firstNumber: '5'
// secondNumber: '6'
// На выходе:
// второе число больше
// или
// первое число больше
// числа равны

System.Console.Write("Введите firstNumber: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите secondNumber: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    System.Console.WriteLine("первое число больше");
}
else if (firstNumber < secondNumber)
{
    System.Console.WriteLine("второе число больше");
}
else
{
    System.Console.WriteLine("числа равны");
}

// // Как должно быть передано в автотесты (РЕШЕНИЕ СИСТЕМЫ)

// // Внутри класса Answer напишите метод CompareNumbers, 
// // который на вход принимает два числа и выводит, какое число большее, а какое меньшее.

// // using System;


// // public class Answer {
// //     static void CompareNumbers(int firstNumber, int secondNumber)
// //     {
// //         if (firstNumber == secondNumber)
// //         {
// //             Console.WriteLine($"числа равны");
// //         }
// //         if (firstNumber > secondNumber)
// //         {
// //             Console.WriteLine($"первое число больше`");
// //         }
// //         if (firstNumber < secondNumber)
// //         {
// //             Console.WriteLine($"второе число больше");
// //         }
// //     }

// //     static public void Main(string[] args) {
// //         int firstNumber, secondNumber;

// //         if (args.Length >= 2) {
// //             firstNumber = int.Parse(args[0]);
// //             secondNumber = int.Parse(args[1]);
// //         } else {
// //             firstNumber = 5;
// //             secondNumber = 5;
// //         }

// //         CompareNumbers(firstNumber, secondNumber);
// //     }
// // }