// ЗАДАЧА 3

// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");

    if (arraySize > 8 || arraySize < 1)
    {
        Console.WriteLine("Некорретный размер массива!");
        return;
    }

    int[] array = GenerateArray(arraySize, 0, 9);
    PrintArray(array);

    // int result = Convert.ToInt32(string.Concat(array));
    // int result = Convert.ToInt32(string.Join("", array));
    int result = FromArrayToNumber(array);
    System.Console.WriteLine(result);
}

int FromArrayToNumber(int[] array)
{
    // [2, 4, 0, 1]
    int number = 0;

    for (int i = 0; i < array.Length; i++)
    {
        number *= 10; // 240
        number += array[i]; // 240
    }

    return number;
}

void PrintArray(int[] arrayForPrint)
{
    Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
        tempArray[i] = rand.Next(minValue, maxValue + 1); // (0, 10)

    return tempArray;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine()); // 13
}

Main();


