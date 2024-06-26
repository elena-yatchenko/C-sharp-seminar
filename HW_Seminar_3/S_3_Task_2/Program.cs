// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// ЗАДАЧА 2
// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

// Начальные условия:

// int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
// Выводится: 6

int[] array = new int[10];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 10);
}

for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + " ");
}

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) count++;
}

System.Console.WriteLine();
System.Console.WriteLine(count);

// //решение системы
// using System;
// using System.Linq;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
//     // Подсчет количества четных элементов массива
//     // numbers - массив, в котором ведется подсчет
//     public static int CountEvenItems(int[] numbers)
//     {
//         int cnt = 0;
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (numbers[i] % 2 == 0)
//             {
//                 cnt++;
//             }
//         }
//         return cnt;
//     }

//     public static void PrintResult(int[] array)
//     {
//         Console.WriteLine(CountEvenItems(array));
//     }
// }


// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[] array;


//         if (args.Length >= 1) {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(int.Parse)
//                                   .ToArray();

//             // Теперь arr содержит преобразованные в целые числа из командной строки

//         } else {
//            // Если аргументов на входе нет
//             array = new int[] {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }