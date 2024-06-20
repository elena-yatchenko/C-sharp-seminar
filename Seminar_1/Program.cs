// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

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

// Применение int.Parse() - переводит строковое значение в число
System.Console.Write("Введите первое число: ");
// string strNumber = Console.ReadLine(); // возвращает строку, НЕ число
// int firstNumber = int.Parse(strNumber); // переводит строку в число int
int firstNumber = int.Parse(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());

// System.Console.WriteLine(firstNumber + 10);

// Convert.ToInt32(Console.ReadLine()) - конвертер, который лучше использовать 
// вместо int.Parse. Он точно так же вызывает внутри себя метод int.Parse, 
// но при этом содержит встроенные проверки, чтобы не выходили ошибки, если 
// пользователь неправильно введет  данные или не введет ничего. 

System.Console.WriteLine(byte.MaxValue);
System.Console.WriteLine(int.MaxValue);
System.Console.WriteLine(long.MaxValue);