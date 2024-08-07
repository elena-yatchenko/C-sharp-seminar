﻿// Задача 1 - Верните элемент из массива по позиции

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет: 
// "Позиция по рядам выходит за пределы массива"
// или
// "Позиция по колонкам выходит за пределы массива"

// Позиции в массиве считать от единицы.

// В коде, начальные условия:

// int[,] numbers = new int[,] {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// };

// int x = 2;
// int y = 2;
// Выводится: 6

void Main()
{
    int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};
    int x = ReadInt("Введите значение х: ");
    int y = ReadInt("Введите значение y: ");

    if (ValidatePosition(numbers, x, y))
    {
        PrintResult(numbers, x, y);
    }

}

int FindElementByPosition(int[,] array, int x, int y)
{
    return array[x - 1, y - 1];
}

bool ValidatePosition(int[,] array, int x, int y)
{
    if ((x > 0 && x <= array.GetLength(0)) && (y > 0 && y <= array.GetLength(1)))
    {
        return true;
    }
    else
    {
        if (x <= 0 || x > array.GetLength(0))
        {
            System.Console.WriteLine("Позиция по рядам выходит за пределы массива");
        }
        else if (y <= 0 || y > array.GetLength(1))
        {
            System.Console.WriteLine("Позиция по колонкам выходит за пределы массива");
        }
        return false;
    }
}
void PrintResult(int[,] numbers, int x, int y)
{
    System.Console.WriteLine(FindElementByPosition(numbers, x, y));
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();


// // РЕШЕНИЕ СИСТЕМЫ

// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
// // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// // Поиск элемента по позициям
//     public static int FindElementByPosition(int[,] array, int x, int y)
//     {
//         return array[x - 1, y - 1];
//     }

// // Проверка позиций на вхождение в массив
//     public static bool ValidatePosition(int[,] array, int x, int y)
//     {
//         if (x <= 0 || x >= array.GetLength(0)) {
//             Console.WriteLine("Позиция по рядам выходит за пределы массива");
//             return false;
//         }
//         if (y <= 0 || y >= array.GetLength(1)) {
//             Console.WriteLine("Позиция по колонкам выходит за пределы массива");
//             return false;
//         }
//         return true;
//     }

//     public static void PrintResult(int[,] numbers, int x, int y)
//     {
//         if (ValidatePosition(numbers, x, y)) {

// Console.WriteLine(FindElementByPosition(numbers, x, y));
//         }
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {   
//         int[,] array;

//         int x, y;

//         if (args.Length >= 3)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             array = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         array[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }

//             // Парсинг x и y из аргументов
//             if (int.TryParse(args[1], out x) && int.TryParse(args[2], out y))
//             {
//                 // Теперь у вас есть двумерный массив "array" и координаты x и y
//                 UserInputToCompileForTest.PrintResult(array, x, y);
//             }
//             else
//             {
//                 Console.WriteLine("Error parsing x or y to an integer.");
//             }
//         }
//         else
//         {

//             // Если аргументов на входе нет, используем примерный массив
//             array = new int[,]
//             {
//                 {1, 2, 3, 4},
//                 {5, 6, 7, 8},
//                 {9, 10, 11, 12}
//             };
//             x = 2;
//             y = 2;

//             UserInputToCompileForTest.PrintResult(array, x, y);

//         }                
//     }
// }
