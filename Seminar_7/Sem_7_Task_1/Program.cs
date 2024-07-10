// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5

// решение через ЦИКЛ
// for (i = 1; i < N; i++)
// {
//     System.Console.WriteLine(i + " ");
// }

void Main()
{
    int number = ReadInt("Введите число: ");
    PrintNumber(number);
}

void PrintNumber(int N)
{
    // выведение в обратном порядке // N=5; результат 5 4 3 2 1
    if (N < 1) return;
    System.Console.Write(N + " ");
    PrintNumber(N - 1);

    // выведение в прямом порядке // N=5; результат 1 2 3 4 5
    if (N < 1) return;
    PrintNumber(N - 1);
    System.Console.Write(N + " ");
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();

