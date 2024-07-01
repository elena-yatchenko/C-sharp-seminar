// ФУНКЦИИ

//Задача 2: 
// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void Main()
{
    int[] myArray = GenerateArray(10, 100, 999);
    // вывод для себя, по задаче не требуется
    PrintArray(myArray);

    System.Console.WriteLine(CountEven(myArray));
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}

// доп. вывод для себя (по задаче не нужен)
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int CountEven(int[] array)
{
    int count = 0;
    foreach (int number in array)
    {
        if (number % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Main();

