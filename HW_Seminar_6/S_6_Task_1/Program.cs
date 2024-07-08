// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

// a b c 
// d e f  => “abcdef”

void Main()
{
    char[,] charMatrix = {
    {'a', 'c', 'c', 'c'},
    {'b', 'b', 'b', 'b'},
    {'a', 'a', 'd', 'd'}
};
    System.Console.WriteLine(CharToString(charMatrix));
}

string CharToString(char[,] matrix)
{
    string resultString = string.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            resultString += matrix[i, j];
        }
    }
    return resultString;
}
Main();

// // РЕШЕНИЕ СИСТЕМЫ

// Задача 1: Создание строки из двумерного массива символов
// public class Task1
// {
//     public static void Main(string[] args)
//     {
//         // Инициализация двумерного массива символов
//         char[,] charArray = new char[,] { { 'a', 'b' }, { 'c', 'd' } };
//         // Вызов метода для создания строки из 2D массива
//         string result = CreateStringFrom2DArray(charArray);
//         // Вывод результата
//         Console.WriteLine(result);
//     }
//     // Метод для создания строки из двумерного массива символов
//     public static string CreateStringFrom2DArray(char[,] array)
//     {
//         string result = "";
//         // Цикл по каждому элементу в двумерном массиве
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 // Добавление каждого символа в результирующую строку
//                 result += array[i, j];
//             }
//         }
//         return result;
//     }