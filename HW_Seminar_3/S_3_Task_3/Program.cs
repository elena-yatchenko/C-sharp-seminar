// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// ЗАДАЧА 3

// Разница между максимальным и минимальным элементов массива

// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

// Начальные условия:

// int[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
// Выводится: 5.15

double[] array = new double[10];

Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(rand.Next(1, 10) + rand.NextDouble(), 2);
}

for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + " ");
}

double maxValue = array[0];
double minValue = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > maxValue) maxValue = array[i];
    if (array[i] < minValue) minValue = array[i];
}
System.Console.WriteLine();
System.Console.WriteLine(maxValue);
System.Console.WriteLine(minValue);
System.Console.WriteLine(Math.Round((maxValue - minValue), 2));


// // решение системы
// using System;
// using System.Linq;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
//     // Разница между максимальным и минимальным элементами массива

//     // Нахождение минимума массива
//     public static double FindMin(double[] numbers)
//     {
//         double min = numbers[0];
//         for (int i = 1; i < numbers.Length; i++)
//         {
//             if (min > numbers[i])
//             {
//                 min = numbers[i];
//             }
//         }
//         return min;
//     }

//     // Нахождение максимума массива
//     public static double FindMax(double[] numbers)
//     {
//         double max = numbers[0];
//         for (int i = 1; i < numbers.Length; i++)
//         {
//             if (max < numbers[i])
//             {
//                 max = numbers[i];
//             }
//         }
//         return max;
//     }



//     public static void PrintResult(double[] array)
//     {

//         double result = FindMax(array) - FindMin(array);
//         Console.WriteLine(result);
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         double[] array;


//         if (args.Length >= 1) {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(double.Parse)
//                                   .ToArray();

//             // Теперь arr содержит преобразованные в целые числа из командной строки

//         } else {
//            // Если аргументов на входе нет
//             array = new double[] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }
