// ЗАДАЧА 3 - Строка с наименьшей суммой элементов
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Начальные условия:

// // Начальные условия
// int[,] numbers = new int[,] {
//     {1, 2, 3},
//     {1, 1, 0},
//     {7, 8, 2},
//     {9, 10, 11}
// };
// Выводится: 1

void Main()
{

    int[,] numbers = new int[,] {
    {1, 10, 1},
    {11, 1, 0},
    {7, 8, 2},
    {0, 1, 0}
};
    PrintMatrix(numbers);
    int minPosition = MinRowPosition(MinSumElements(numbers));
    System.Console.WriteLine($"Номер строки с минимальной суммой элементов - {minPosition}");

}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            // 
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }

    System.Console.WriteLine();
}

int[] MinSumElements(int[,] matrix)
{
    // int min = 0;
    // int minRowPosition = 0;
    int numRows = matrix.GetLength(0);
    int numCols = matrix.GetLength(1);
    int[] sums = new int[numRows];

    for (int i = 0; i < numRows; i++)
    {
        int rowSum = 0;
        for (int j = 0; j < numCols; j++)
        {
            rowSum += matrix[i, j];
        }
        sums[i] = rowSum;
    }

    return sums;
}

int MinRowPosition(int[] array)
{
    int min = array[0];
    int minRowPosition = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minRowPosition = i;
        }
    }
    return minRowPosition;
}

Main();

// // РЕШЕНИЕ СИСТЕМЫ

// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     /// Вычисление сумм по строкам (на выходе массив с суммами строк)
//     public static int[] SumRows(int[,] array)
//     {
//         int[] sum = new int[array.GetLength(0)];
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 sum[i] += array[i, j];
//             }
//         }
//         return sum;
//     }

//     // Получение индекса минимального элемента в одномерном массиве
//     public static int MinIndex(int[] array)
//     {
//         int minI = 0;
//         for (int i = 0; i < array.Length; i++)
//         {
//             if (array[minI] > array[i])
//             {
//                 minI = i;
//             }
//         }
//         return minI;
//     }
//     public static void PrintResult(int[,] numbers)
//     {   
//         int[] sums = SumRows(numbers);
//         int minIndex = MinIndex(sums);
//         Console.Write(minIndex);
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[,] numbers;

//         if (args.Length >= 1)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             numbers = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         numbers[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }
//         }
//         else
//         {
//             // Если аргументов на входе нет, используем примерный массив

//             numbers = new int[,] {
//                 {1, 2, 3},
//                 {1, 1, 0},
//                 {7, 8, 2},
//                 {9, 10, 11}
//     };      
//         }
//         UserInputToCompileForTest.PrintResult(numbers);
//     }
// }

