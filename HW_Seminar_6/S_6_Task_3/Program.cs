// Задача 3: 
// Задайте произвольную строку. Выясните, является ли она палиндромом.

// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

void Main()
{
    System.Console.Write("Введите строку для проверки: ");
    string? testData = Console.ReadLine();

    if (IsPalindrom(testData!))
    {
        System.Console.WriteLine("Строка - ПАЛИНДРОМ");
    }
    else
    {
        System.Console.WriteLine("Нет, строка палиндромом не является");
    }

}

string ReverseString(string data)
{
    string reversedString = string.Empty;

    for (int i = 0; i < data.Length; i++)
    {
        reversedString += data[data.Length - 1 - i];
    }
    return reversedString;
}

bool IsPalindrom(string data)
{
    if (data.ToLower() == ReverseString(data.ToLower())) { return true; }
    return false;
}

Main();

// РЕШЕНИЕ СИСТЕМЫ
// Задача 3: Проверка строки на палиндром
// public class Task3
// {
//     public static void Main(string[] args)
//     {
//         // Входная строка для проверки
//         string input = "шалаш";
//         // Вызов метода для проверки, является ли строка палиндромомbool isPalindrome = IsPalindrome(input);
//         // Вывод результата
//         Console.WriteLine(isPalindrome ? "Да" : "Нет");
//     }
// // Метод для проверки, является ли строка палиндромомpublic static bool IsPalindrome(string str)
// {
// // Нормализация строки путем удаления не буквенно-цифровыхсимволов и приведения к нижнему регистру
// string normalized = new
// string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
// // Сравнение строки с ее перевернутым вариантом
// return normalized.SequenceEqual(normalized.Reverse());
// }
// }