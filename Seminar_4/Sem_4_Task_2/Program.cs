// ЗАДАЧА 2

/ Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

void Main()
{
    // string request = "Введите размер массива";
    // int arraySize = ReadInt(request);
int arraySize = ReadInt("Введите размер массива: ");
int[] array = GenerateArray(arraySize, 20, 23);
PrintArray(array);
System.Console.WriteLine(CountNumbers(array, 7, 1));
}

int CountNumbers(int[] arr, int div, int end)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % div == 0 && arr[i] % 10 == end)
            count++;

    return count;
}

void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
        System.Console.Write(arrayForPrint[i] + " ");

    System.Console.WriteLine();
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
        tempArray[i] = rand.Next(minValue, maxValue);

    return tempArray;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine()); // 13
}

Main();
