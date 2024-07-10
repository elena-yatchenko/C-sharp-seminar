// Задача 1: 
// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// Можно, по идее, добавить проверки, чтобы второе число было не меньше первого, и чтобы оба числа были больше 0

void Main()
{
    int M = ReadInt("Введите первое число: ");
    int N = ReadInt("Введите второе число: ");
    PrintNumber(M, N);
}

void PrintNumber(int first, int last)
{
    if (last < first) return;
    PrintNumber(first, last - 1);
    System.Console.Write(last + " ");
}

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
