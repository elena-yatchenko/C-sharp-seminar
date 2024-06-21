// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// ЗАДАЧА 1
// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// int a = int.Parse(Console.ReadLine());

// int firstNumber = 25;
// int secondNumber = 7;

// // string str = "a = " + firstNumber + ", b = " + secondNumber;

// if (firstNumber == secondNumber * secondNumber)
// {
//     // вывод через конкатинацию строк
//     Console.WriteLine("a = " + firstNumber + ",     b = " + secondNumber + " => да");
// }
// else
// {
//     // вывод через f-строку (отличие от Python - знак $, a не f)
//     Console.WriteLine($"a = {firstNumber}, b = {secondNumber} => нет");
// }

// // Применение int.Parse() - переводит строковое значение в число
// System.Console.Write("Введите первое число: ");
// // string strNumber = Console.ReadLine(); // возвращает строку, НЕ число
// // int firstNumber = int.Parse(strNumber); // переводит строку в число int
// int firstNumber = int.Parse(Console.ReadLine());

// System.Console.Write("Введите второе число: ");
// int secondNumber = int.Parse(Console.ReadLine());

// System.Console.WriteLine(firstNumber + 10);

// Convert.ToInt32(Console.ReadLine()) - конвертер, который лучше использовать 
// вместо int.Parse. Он точно так же вызывает внутри себя метод int.Parse, 
// но при этом содержит встроенные проверки, чтобы не выходили ошибки, если 
// пользователь неправильно введет  данные или не введет ничего. 

// System.Console.WriteLine(byte.MaxValue);
// System.Console.WriteLine(int.MaxValue);
// System.Console.WriteLine(long.MaxValue);

// Convert.ToInt32() - конвертация в int
// Convert.ToInt16() - конвертация в byte
// Convert.ToInt64() - конвертация в long

// итоговый код по первой задаче: 

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber) // true
{
    Console.WriteLine("a = " + firstNumber + ", b = " + secondNumber + " => да");
}
else
{
    Console.WriteLine($"a = {firstNumber}, b = {secondNumber} => нет");
}

// ЗАДАЧА 2
// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2


// Console.Write("Введите положительное число:");
// int number = Convert.ToInt32(Console.ReadLine());

// // убрать ошибку некорректного ввода (НЕ положительное число) можно добавив
// // условие, хотя это не лучший вариант, но доступный на данном этапе обучения. 
// if (number <=0)
// {
//     System.Console.WriteLine("Вы ввели некорректное число!");
// }
// else
// {
//     int i = -number;
//     while (i <= number)
//     {
//         System.Console.Write(i + " ");
//         i++; // аналоги i = i + 1; // i += 1;
//     }
// }
// // аналогичный результат можно получить через цикл for, но объявление переменной, 
// // условие для завершения цикла и инкремент (увеличение счетчика на 1) в этом случае
// // прописывается прямо в аргументах цикла.

// for (int i = -number; i <= number; i++)
// {
//     System.Console.Write(i + " ");
// }

// // минус в том, что обращаться к переменной i вне цикла не можем
// // либо же ее можно вынести ВНЕ ЦИКЛА for (не забыть ; в аргументах для цикла for):
// int i = 0;
// for ( ;i <= number; i++)
// {
//     System.Console.Write(i + " ");
// }

// // 2 варианта запускать БЕСКОНЕЧНЫЙ цикл
// // while(true) и for (;;) - т.е. в for не указываем аргументы, или можем не указать 
// // ТОЛЬКО условие прекращения цикла
// int i = 0;
// while(true)
// {
//     System.Console.WriteLine(i + " ");
//     i++;
// }

// for (int i=0; ;i++)
// {
//     System.Console.WriteLine(i + " ");
// }

// // применение разделителей в циклах: например, если хотим вывести цифры через запятую, 
// // то цикл даст после последнего числа тоже запятую. Решение - вывести последнее
// // число вручную отдельно (вне цикла)

// for (int i = -number; i <= number; i++)
// {
//     System.Console.Write(i + ", ");
// }
// System.Console.Write(number);

// ЗАДАЧА 3
// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

Console.Write("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
// &&  - двойной амперсанд - логическое И
if (number > 99 && number < 1000)
// сравнение как в Python сразу с 2 числами (99 < number < 1000) в С# не проходит
{
    System.Console.WriteLine("Число корректное!");
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    int sum = firstDigit + thirdDigit;
    System.Console.WriteLine(sum);
    // или
    // System.Console.WriteLine(number / 100 + number % 10);
}
else
{
    System.Console.WriteLine("Введено не трехзначное число!!!");
}

// 7/2 = 3, т.к. / - целочисленное деление
// 7 % 2 = 1, т.к. % - получение остатка от деления (деление по модулю)

// System.Console.WriteLine(329 / 100); // первая цифра числа
// System.Console.WriteLine(329 % 10); // последняя цифра 
// остатком любого числа, деленного на 10 будет последняя цифра этого числа
