// Задача 4*(не обязательная): 
// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

// “Hello my world” => “world my Hello”

void Main()
{
    string? testString = ReadData("Введите строку: ");
    string[] reversedArray = ReverseArray(DivideStringToArray(testString!));
    System.Console.WriteLine(ArrayToString(reversedArray));
    
    // // Можно через void метод Array.Reverse()
    // string? testString = ReadData("Введите строку: ");
   
    // string[] wordList = DivideStringToArray(testString!);
    // Array.Reverse(wordList);
    // System.Console.WriteLine(ArrayToString(wordList));
   
}

string? ReadData(string msg)
{
    System.Console.Write(msg);
    return Console.ReadLine();
}

string[] DivideStringToArray(string data)
{
    return data!.Split();
}

string[] ReverseArray(string[] dataArray)
{
    string[] reversedWordList = new string[dataArray.Length];
    for (int i = 0; i < dataArray.Length; i++)
    {
        reversedWordList[i] = dataArray[dataArray.Length - 1 - i];
    }
    return reversedWordList;

}

string ArrayToString(string[] dataArray)
{
    string reversedString = string.Join(" ", dataArray);
    return reversedString;
}

Main();

// // РЕШЕНИЕ СИСТЕМЫ

// Задача 4 (необязательная): Обратный порядок слов в строкеpublic class Task4
// {
//     public static void Main(string[] args)
//     {
//         // Входная строка со словами, разделенными пробелами
//         string input = "Hello my world";
//         // Вызов метода для обращения порядка слов в строке
//         string result = ReverseWords(input);
//         // Вывод результата
//         Console.WriteLine(result);
//     }
//     // Метод для обращения порядка слов в строке
//     public static string ReverseWords(string str)
//     {
//         // Разделение строки на слова
//         string[] words = str.Split(' ');
//         // Обращение порядка слов
//         Array.Reverse(words);
//         // Соединение слов обратно в строку с пробелами
//         return string.Join(" ", words);
//     }
// }