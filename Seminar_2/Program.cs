// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// ЗАДАЧА 1
// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    // можно решить через строку
    // System.Console.Write(number / 100 + "" + number % 10);
    // можно решить через строку с последующей конвертацией в число, с которым можно дальше математику делать
    // int result = Convert.ToInt32(number / 100 + "" + number % 10);
    // System.Console.WriteLine(result + 10);
    // можно решить сразу математически, через число
    int result = number / 100 * 10 + number % 10;
    System.Console.WriteLine(result);
}
else
{
    Console.WriteLine("Вы ввели не трехзачное число!");
}

// ЗАДАЧА 2
// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int digit = number / 10 % 10; // находим вторую цифру трехзначного числа
    int result = 1; // вводим переменную result и задаем начальное значение
                    // power-- то же самое, что power -= 1 (power = power - 1) - ДЕКРЕМЕНТ
    for (int power = number % 10; power > 0; power--)
        result *= digit; // result = result * digit

    System.Console.WriteLine(result);
}
else
{
    Console.WriteLine("Вы ввели не трехзачное число!");
}

// for(int power = number % 10; power > 0; power--)
// result *= digit; // result = result * digit

// System.Console.WriteLine(result);
// если мы не обозначили {} контекст для цикла for (т.е. какая часть кода относится к телу цикла), 
// в этом случае в цикле выполняется только первая строчка, все остальные программа воспринимает ВНЕ тела цикла.  

// ЗАДАЧА 3
// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

System.Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber % secondNumber == 0)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет, " + firstNumber % secondNumber);
}

// ЗАДАЧА 4
// Напишите программу, которая выводит третью с
// конца цифру заданного числа или сообщает, что
// третьей цифры нет.
// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет

// третью цифру с начала

// 3 цифра с конца
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    System.Console.WriteLine(number % 1000 / 100);
    // 128475 % 1000 = 475 / 100 = 4
}
else
    System.Console.WriteLine("Третьей цифры нет!");

// 3 цифра с начала
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    while (number > 999)
        number /= 10; // в итоге любое число приведем к трехзначному, далее 3 цифру получаем через % 10

    System.Console.WriteLine(number % 10);
}
else
    System.Console.WriteLine("Третьей цифры нет!");

    