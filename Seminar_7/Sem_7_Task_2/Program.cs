// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

void Main()
{
    int number = ReadInt("Введите число: ");
    System.Console.WriteLine(SumDigitsOfNumber(number));
}

int SumDigitsOfNumber(int N)
{
    if (N < 1) return 0;
    return N % 10 + SumDigitsOfNumber(N / 10);
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
