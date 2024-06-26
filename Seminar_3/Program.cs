// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// // МАССИВЫ
// //Размер массива нельзя менять, можно создать другой и перезаписать наш туда.
// // Т.е. размер оперативной памяти для нашего массива задаем уже при его создании

// // ЗАПОЛНЕНИЕ МАССИВА
// //1 вариант заполнения - через код

// int[] nums1 = { 1, 6, 7, 2, 1 };

// // 2 вариант - поэлементно принимать значения от пользователя
// // ключевое слово new выделяет место в оперативной памяти под наш объект

// int[] nums2 = new int[4]; // по умолчанию заполняется нулями
// for (int i = 0; i < nums2.Length; i++)
// {
//     System.Console.Write($"Введите {i + 1}-й элемент массива: ");
//     nums2[i] = Convert.ToInt32(Console.ReadLine());
// }

// for (int i = 0; i < nums2.Length; i++)
//     System.Console.Write(nums2[i] + " ");

// // 3 способ - ввод одной строкой
// System.Console.WriteLine("Введите значения массива через запятую: ");
// int[] nums3 = Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);
// // Split() -  разделит введенную строку на подстроки, разделитель указываем в 
// // аргумент метода, по умолчанию разделитель - пробел (" ")
// // ! знак после метода ставится, чтобы не выдавалось в консоль предупреждение
// // int.Parse - конвертер (сейчас конвертирует в int)
// // ConvertAll - конвертирует массив одного типа данных в массив другого типа данных

// for (int i = 0; i < nums3.Length; i++)
//     System.Console.Write(nums3[i] + " ");

// // 4 способ - генерация массива случайных чисел

// int[] nums4 = new int[5]

// for (int i = 0; i < nums4.Length; i++)
// {
//     // обращаемся к методу Next класса Random
//     nums1[i] = new Random().Next(0, 10);
// }


// for (int i = 0; i < nums4.Length; i++)
//     System.Console.Write(nums4[i] + " ");

// // минус записи генерации случайного числа, показанной выше: т.е. в цикле есть 
// // ключевое слово new, то для генерации каждого числа выделяется новая ячейка.
// // чтобы не тратить так много оперативной памяти, нужно объявить экземпляр класса
// // Random, в этом случае каждое новое число будет генерироваться в одной и той же ячейке оперативки

// Random rand = new Random();
// // тогда получим

// int[] nums4 = new int[5]
// Random rand = new Random(); // создана вне цикла, т.е. один раз создается

// for (int i = 0; i < nums4.Length; i++)
// {
//     // обращаемся к одной и той же ячейке - экземпляру класса Random
//     nums1[i] = rand.Next(0, 10);
// }

// for (int i = 0; i < nums4.Length; i++)
//     System.Console.Write(nums4[i] + " ");
// // генерируем массив нажатием клавиши (любой) - через ReadKey. Но при нажатии буквы 
// // будет и буква выводиться перед рандомным числом

// for (; ; )
// {
//     System.Console.WriteLine(new Random().Next(0, 10));
//     Console.ReadKey();
// }

// ЗАДАЧА 1
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] array = new int[arraySize];
Random rand = new Random();

// Операции лучше привыкать разделять между собой (например, заполнение и выведение на печать)
// далее в методах (функциях) это именно так и применяется: один метод - одна операция

// Заполнение массива
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(10, 100);
}

// Вывод массива
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

Console.Write("\nВведите искомое значение: ");
int findNumber = Convert.ToInt32(Console.ReadLine());

bool numberIsFinded = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == findNumber)
    {
        numberIsFinded = true;
        break;
    }
}

if (numberIsFinded)
    System.Console.WriteLine("Да!");
else
    System.Console.WriteLine("Нет!");

// ЗАДАЧА 2

// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

int[] array = new int[10];
Random rand = new Random();

// Заполнение массива
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-10, 11);
}

// Вывод массива
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + "\t");
}
System.Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1; // array[i] = -array[i]; // array[i] = array[i] * -1;
}

// Вывод массива
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + "\t");
}

// ЗАДАЧА 3

// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

Random rand = new Random();

int[] array = new int[rand.Next(5, 16)];

// // Заполнение массива
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-10, 11);
}

// Вывод массива
foreach (int number in array)
{
    System.Console.Write(number + " ");
}
System.Console.WriteLine();

int[] multPairs = new int[array.Length / 2];

for (int i = 0; i < array.Length / 2; i++)
{
    multPairs[i] = array[i] * array[array.Length - 1 - i];
}

foreach (int number in multPairs)
    System.Console.Write(number + " ");

// !!!!!
// через цикл foreach нельзя изменять переменные, потому что переменные этого 
// цикла доступны только для чтения (вывести элементы на печать можно, заполнить массив через 
// этот цикл (т.е. изменить его элементы) нельзя).
// Также его неудобно использовать, если нам нужна только часть массива

// для ДЗ (ГЕНЕРИРОВАНИЕ СЛУЧАЙНЫХ ВЕЩЕСТВЕННЫХ ЧИСЕЛ)

double[] numbers = new double[5];
Random rand = new Random();

for (int i = 0; i < numbers.Length; i++)
    //numbers[i] = rand.Next(0, 10);
    //numbers[i] = rand.NextDouble();
    // метод Next генерирует только целые числа, а нам нужны вещественные (с запятой)
    // метод NextDouble генерирует вещественные числа в диапазоне от 0 до 1. НО у них
    // будет нулевая целая часть, а нам по задаче надо НЕ НУЛЕВАЯ.
    numbers[i] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 2);
for (int i = 0; i < numbers.Length; i++)
    System.Console.Write(numbers[i] + " ");

// для округления до определенного количества знаков - Math.Round(число, количество знаков)
// System.Console.WriteLine(Math.Round(3.14521471251541321, 2));


// МЕТОД CONCAT - склеивание коллекций

int[] arr1 = { 1, 2, 3, 4 };
int[] arr2 = { 99, 100 };

int[] res = arr1.Concat(arr2).ToArray();
// ToArray() нужно, т.к. метод Concat это метод коллекций (динамические массивы), 
// теперь коллекцию нужно перевести в наш обычный (нединамический) массив

System.Console.WriteLine(string.Join(", ", res));
// можно переприсвоить новый (результирующий) массив на место старого
// arr1 = arr1.Concat(arr2).ToArray();

