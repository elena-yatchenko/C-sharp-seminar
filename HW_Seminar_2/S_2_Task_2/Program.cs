// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Задача 2: 
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

System.Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0)
{
    System.Console.WriteLine("Введенное число не должно быть равно 0!");
}
else
{
    if (x < 0 && y > 0) System.Console.WriteLine("1 quoter");
    else if (x > 0 && y > 0) System.Console.WriteLine("2 quoter");
    else if (x < 0 && y < 0) System.Console.WriteLine("3 quoter");
    else if (x > 0 && y < 0) System.Console.WriteLine("4 quoter");
}

// РЕШЕНИЕ СИСТЕМЫ

// // Задача 2: Определение координатной четверти
// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите координаты точки X и Y через пробел:"); string[] coordinates = Console.ReadLine().Split(' ');
//         int x = Convert.ToInt32(coordinates[0]);
//         int y = Convert.ToInt32(coordinates[1]);
//         if (x > 0 && y > 0)
//             Console.WriteLine("1");
//         else if (x < 0 && y > 0)
//             Console.WriteLine("2");
//         else if (x < 0 && y < 0)
//             Console.WriteLine("3");
//         else if (x > 0 && y < 0)
//             Console.WriteLine("4");
//         else
//             Console.WriteLine("Точка находится на оси координат");
//     }
// }