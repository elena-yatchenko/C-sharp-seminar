// Задача 2: 
// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// “aBcD1ef!-” => “abcd1ef!-”

void Main()
{
    string mixStr = "fjeRGJJFNfjrFU";
    System.Console.WriteLine(LowerString(mixStr));
}

string LowerString(string data)
{
    return data.ToLower();
}

Main();

//РЕШЕНИЕ СИСТЕМЫ

// Задача 2: Замена заглавных букв на строчные в строке
// public class Task2
// {
//     public static void Main(string[] args)
//     {
//         // Входная строка со смешанными буквами обоих регистровstring input = "aBcD1ef!-";
//         // Преобразование всех заглавных букв в строчные
//         string result = input.ToLower();
//         // Вывод результата
//         Console.WriteLine(result);
//     }
// }