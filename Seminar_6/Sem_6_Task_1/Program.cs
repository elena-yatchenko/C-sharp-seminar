// Задайте массив символов(тип char[]). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

void Main()
{
char[] chars = { 'a', 'b', 'c', 'd' };

// 1-й способ
// string str = new string(chars);
// System.Console.WriteLine(str);

// 2-й способ
// System.Console.WriteLine(CharsToString(chars)) ;

// 3-й способ
// System.Console.WriteLine(string.Join("", chars));

// 4-й способ
System.Console.WriteLine(string.Concat(chars));

}

// string CharsToString(char[] letters)
// {
// string str = ""; // не то же самое, что и null

// foreach (char letter in letters)
// str += letter;

// return str;
// }

Main();
