// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 4**(не обязательно): 
// Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.

// 425 => [4 2 5]
// 8741 => [8 7 4 1]
// 4 => [4]

System.Console.WriteLine("Введите число от 1 до 100 000: ");
int number = Convert.ToInt32(Console.ReadLine());
int currNumber = number;
int count = 0;

while (number > 0)
{
    count++;
    number = number / 10;
}

int[] array = new int[count];

for (int i = 0; i < array.Length; i++)
{
    int digit = currNumber % 10;
    array[array.Length - 1 - i] = digit;
    currNumber = currNumber / 10;
}

for (int i = 0; i < array.Length; i++)
    System.Console.Write(array[i] + " ");

// 65841
// 6 5 8 4 1 