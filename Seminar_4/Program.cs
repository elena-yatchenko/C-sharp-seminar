// Обычно применяется следующий подход. Сначала определяется метод Main (главный метод),
// внутри которого другие фунцкии обычно и вызываются. А после него уже определяются все другие (доп) функции
void Main()
{
    PrintText();

    System.Console.WriteLine();
    System.Console.WriteLine("Example");
    System.Console.WriteLine();

    PrintText();
}

void PrintText()
{
    System.Console.WriteLine("Hello, world!");
    System.Console.WriteLine("Hi there!");
    System.Console.WriteLine("It's me!");
}

Main();