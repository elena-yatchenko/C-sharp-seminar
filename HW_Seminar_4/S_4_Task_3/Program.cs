// ФУНКЦИИ

// Задача 3: 
// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

void Main()
{
    int[] myArray = FillArray(GenerateArray(12), 10, 100);
    PrintArray(myArray);
    PrintArray(ReverseArray(myArray));
}

// разделила методы Generate и Fill, т.к. дополнительно использую Generate в методе Reverse ниже)
int[] GenerateArray(int size)
{
    int[] array = new int[size];
    return array;
}

int[] FillArray(int[] array, int minValue, int maxValue)
{
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] ReverseArray(int[] array)
{
    int[] newArray = GenerateArray(array.Length);

    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[array.Length - 1 - i];
    }
    return newArray;
}
Main();