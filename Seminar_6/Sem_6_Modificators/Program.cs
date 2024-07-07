// МОДИФИКАТОРЫ

// Модификаторы позволяют обращаться к значимым типам данных (см. инфо в семинаре 5) как к ссылочным

// Существуют следующие модификаторы: ref, out, in
// 1. ref - позволяет передавать нашу переменную как ссылочную. 
// Особенность: переменная должна быть обязательно объявлена заранее и ей должно 
// быть присвоено значение (= должна быть инициализирована). То есть ей должна быть присвоена какая-то область в оперативной
// памяти, на которую можно ссылаться. А присваивается она при присвоении значения переменной
// (даже если это значение - пустая строка "")

// 2. out - действие аналогичное. Разница - переменную не обязательно объявлять заранее,
// это можно сделать при объявлении функции, НО обязательно внутри функции эту переменную 
// инициализировать (присвоить значение)

// 3. in - переменную нужно объявлять заранее (ДО использования в функции). Можем передавать 
// значимую переменную как ссылочную, считывать ее значениепо ссылке, НО модифицировать ее не можем. 
// Например, можем присвоить ее значение другой переменной. Зачем нужно, почему не отправить просто как значимую
// переменную и ее считывать? 
// В C# есть такое понятие, как структура (набор переменных). Если у нас есть ряд переменных значимого типа, 
// и если мы их все отправим в функцию, чтобы использовать их значения, то в Стеке для них создадутся
// дубликаты для работы этой функции, что занимает оперативную память. А если передавать просто значения по ссылке, 
// не дублируя данные в оперативной памяти (через модификатор IN), то это экономит оперативную память . 

// ИСПОЛЬЗОВАНИЕ МОДИФИКАТОРОВ (ПРИМЕРЫ)
// Метод TryParse возвращает булево значение. Т.е. его можно ипользовать в условии, чтобы 
// понять он возвращает 0, потому что пользователем было введено значение "0", либо же 
// потому что введены были не цифровые символы и их не удалось сконвертитьвать в число.

if (int.TryParse("fdgregtrgdg", out int number))
    System.Console.WriteLine(number);
else
    System.Console.WriteLine("Не получилось :(");

// Модификаторы можно использовать, когда нужно вернуть из фукнции несколько значений. 
// Оператор return это сделать не даст (или же нужно создавать массив, потом из него вытаскивать эти
// переменные). А модификатор out позволяет (см. пример )

void Main()
{
    F(out int firstValue, out int secondValue);
    System.Console.WriteLine(firstValue);
    System.Console.WriteLine(secondValue);
}

void F(out int a, out int b)
{
    //
    a = 0;
    b = 7;
}
Main();

// РЕШЕНИЕ ДЗ №4 (СЕМИНАРА 5) С ИСПОЛЬЗОВАНИЕМ МОДИФИКАТОРОВ

// Задача 4*(не обязательная): Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца

// 4 3 1 =>  2 6
// 2 6 9     4 6
// 4 6 2

void Main()
{
    int rowCount = ReadInt("Введите количество строк двумерного массива: ");
    int colCount = ReadInt("Введите количество столбцов двумерного массива: ");

    int[,] matrix = GenerateMatrix(rowCount, colCount, 0, 9);
    PrintMatrix(matrix);
    FindMinElementIndexes(matrix, out int minRow, out int minCol);
    matrix = DeleteRowAndCol(matrix, minRow, minCol);
    PrintMatrix(matrix);
}

int[,] DeleteRowAndCol(int[,] matrix, int delRow, int delCol)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

    // int x = 0;
    // for (int i = 0; i < matrix.GetLength(0); i++)
    for (int i = 0, x = 0; i < matrix.GetLength(0); i++)
    {
        // int y = 0;
        // for (int j = 0; j < matrix.GetLength(1); j++)
        if (i == delRow) continue;
        for (int j = 0, y = 0; j < matrix.GetLength(1); j++)
        {
            if (j == delCol) continue;
            newMatrix[x, y] = matrix[i, j];
            y++;
        }
        x++;
    }

    return newMatrix;
}

void FindMinElementIndexes(int[,] matrix, out int rowIndex, out int colIndex)
{
    rowIndex = 0;
    colIndex = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (matrix[rowIndex, colIndex] > matrix[i, j])
            {
                rowIndex = i;
                colIndex = j;
            }
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }

    System.Console.WriteLine();
}

int[,] GenerateMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] tempMatrix = new int[rows, cols];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(minValue, maxValue + 1);
        }
    }

    return tempMatrix;
}

Main();