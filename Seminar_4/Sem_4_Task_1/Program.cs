// В языке C# сначала принято определять метод Main (главный метод),
// внутри которого уже вызываются все прочие методы. Прочие методы определяются после (ниже) метода Main
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

// Принципы Объекто-ориентированного программирования в C#:
// 1 - Single Responsibility Principe -  Т.е. каждый метод отвечает за выполнение 
// какого-то одного действия/функции/задачи

// стандартная часть для решения большинства домашних задач:
// - прием значения от пользователя
// - генерирование массива
// - выведение массива

void Main()
{
    // string request = "Введите размер массива";
    // int arraySize = ReadInt(request);
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 0, 10);
    PrintArray(array);
}

void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
        System.Console.Write(arrayForPrint[i] + " ");

    System.Console.WriteLine();
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
        tempArray[i] = rand.Next(minValue, maxValue);

    return tempArray;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine()); // 13
}

Main();

// ЗАДАЧА 1
// Простое число - положительное число, которое делится нацело только на 1 или само на себя. 1 (единица) - не простое.
// Будем использовать метод Среднеквадратичного решета, т.е. делить наше проверяемое 
// число поочередно на все числа до квадрата этого числа. Если не делится, значит не будет 
// делиться и на числа после квадрата.
// Например, число 27. Квадрат приблизительно 5,2. Значит делим 27 на 2, 3, 4, 5. 

// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 0, 20);
    PrintArray(array);
    System.Console.WriteLine(CountPrimary(array));

}

int CountPrimary(int[] array)
{
    int count = 0;

    foreach (int num in array)
        if (isPrimary(num))
            count++;

    return count;
}

bool isPrimary(int number)
{
    if (number < 2)
        return false;

    for (int i = 2; i <= Math.Sqrt(number); i++)
        if (number % i == 0)
            return false;

    return true;
}

void PrintArray(int[] arrayForPrint)
{
    Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
        tempArray[i] = rand.Next(minValue, maxValue + 1); // (0, 10)

    return tempArray;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine()); // 13
}

Main();
