// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

void Main()
{
    System.Console.Write("Ведите строку: ");
    string? str = Console.ReadLine();
    System.Console.WriteLine(CountVowels(str));
    // TEXT
}

int CountVowels(string? str)
{
    int count = 0; // 0 -> 1

    str = str!.ToLower(); // "TEXT" -> "text"

    foreach (char letter in str) // letter = 't'
        if (isVowel(letter))
            count++;

    return count;
}

// 'x'
bool isVowel(char c)
{
    return "aeiouy".Contains(c); // c = x -> false
}

Main();
