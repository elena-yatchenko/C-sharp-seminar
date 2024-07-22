// Задача 3: 
// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int size = ReadInt("Введите размер массива: ");
    int minValue = ReadInt("Введите начало диапазона: ");
    int maxValue = ReadInt("Введите конец диапазона: ");

    int[] myArray = FillArray(GenerateArray(size), minValue, maxValue);
    // PrintByCycle(myArray);
    // System.Console.WriteLine();
    PrintByRecursion(myArray);
    System.Console.WriteLine();
    PrintByRecursionReverse(myArray);

}
void PrintByCycle(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

void PrintByRecursion(int[] array)
{
    if (array.Length < 1) return;
    System.Console.Write(array[0] + " ");
    PrintByRecursion(array[1..]);
}

void PrintByRecursionReverse(int[] array)
{
    if (array.Length < 1) return;
    PrintByRecursionReverse(array[1..]);
    System.Console.Write(array[0] + " ");
}

int[] GenerateArray(int size)
{
    return new int[size];
}

//  я не стала извращаться и придумывать как заполнить массив рекурсивно, сорри :)
int[] FillArray(int[] array, int start, int stop)
{
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(start, stop);
    }
    return array;
}
int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
