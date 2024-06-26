// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// ЗАДАЧА 1
// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,90].

// Начальные условия:

// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
// Выводится: 5

int[] numbers = new int[10];
Random rand = new Random();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rand.Next(1, 101);
}
int maxRange = 90;
int minRange = 10;
int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    System.Console.Write(numbers[i] + " ");
}

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] >= minRange && numbers[i] <= maxRange) count++;
}

System.Console.WriteLine();
System.Console.WriteLine(count);

// // ответ системы
// using System;
// using System.Linq;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 

//     // Подсчет количества элементов массива, попадающих в заданный диапазон
//     // numbers - массив, в котором ведется подсчет
//     // minRange - минимальная граница диапазона
//     // maxRange - максимальная граница диапазона
//     public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
//     {
//         int cnt = 0;
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (numbers[i] >= minRange && numbers[i] <= maxRange)
//             {
//                 cnt++;
//             }
//         }
//         return cnt;
//     }

//     public static void PrintResult(int[] array)
//     {

//         Console.WriteLine(CountItemsRange(array, 10, 90));
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
//             array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }
