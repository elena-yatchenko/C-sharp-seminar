// ФУНКЦИИ

// Задача 1: 
// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

void Main()
{
    while (true)
    {
        string dataForChecking = ReadData("Введите ваше значение: ");
        if (CheckIfQ(dataForChecking) || CheckIfEven(dataForChecking))
            break;
    }
}

string ReadData(string message)
{
    System.Console.Write(message);
    return Console.ReadLine();
}

bool CheckIfQ(string data)
{
    if (data.ToLower() == "q")
        return true;
    else
        return false;
}

bool CheckIfEven(string data)
{
    int number = Convert.ToInt32(data);
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }

    if (sum % 2 == 0)
        return true;
    else
        return false;
}

Main();