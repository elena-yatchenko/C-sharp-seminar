// ТЕРНАРНЫЕ ОПЕРАТОРЫ (РЕШЕНИЕ ЗАДАЧИ ДЗ 4 СЕМИНАРА 5)

// УНАРНЫЙ оператор - оператор, который работает с одной переменной. Пример: инеремент (увеличение счетчика на единицу) i++
// БИНАРНЫЙ оператор - работает с двумя значениями (оператор сложения) a + b
// ТЕРНАРНЫЙ оператор - с тремя значенями

int a = 10;
int b = 5;
int c = (a > b) ? (a + b) : (a * b); // скобки здесь не нужны по сути, поставлены для улучшения читаемости кода
System.Console.WriteLine(c);

// расшифровка: если переменная а больше б, тогда в переменную с запишем результат сложения а + б, 
// в противном случае - результат их перемножения.

// можно записать так
// if (a > b)
//     c = a + b;
// else
//     c = a * b;


// Например, для задачи 4 будет запись следующего вида (см. ниже в коде)
// x = (i < delRow) ? i : i + 1;
// то есть, пока мы не дошли до строки, которую нужно удалить, x будет равен i матрицы. 
// Когда дошли до удаляемой строки, x будет равен i + 1.
// Аналогично и с номерами колонок y и j.
// !!! Обратить внимание, тут i (j) - индексы новой матрицы (не старой, как в решении с модификаторами и в моем)

// Задача 4*(не обязательная): Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца

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

    for (int i = 0, x = 0; i < newMatrix.GetLength(0); i++)
    {
        x = (i < delRow) ? i : i + 1;
        for (int j = 0, y = 0; j < newMatrix.GetLength(1); j++)
        {
            y = j < delCol ? j : j + 1;
            newMatrix[i, j] = matrix[x, y];
        }
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