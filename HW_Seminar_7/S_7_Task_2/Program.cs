// Задача 2: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

void Main()
{
    int M = ReadInt("Введите первое число: ");
    int N = ReadInt("Введите второе число: ");
    System.Console.WriteLine(A(M, N));
}

int A(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0 && m > 0)
        return A(m - 1, 1);
    else
        return A(m - 1, A(m, n - 1));
}

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

Main();


