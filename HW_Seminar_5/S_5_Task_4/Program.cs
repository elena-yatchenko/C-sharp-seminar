// ЗАДАЧА 4

// Задача 4*(не обязательная): Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива (смотрим первое вхождение элемента). 
// Под удалением понимается создание нового двумерного массива без
// строки и столбца

// 4 3 1 =>  2 6
// 2 6 9     4 6
// 4 6 2

void Main()
{
    int rowCount = ReadInt("Введите количество строк двумерного массива: ");
    int colCount = ReadInt("Введите количество столбцов двумерного массива: ");

    if (rowCount <= 1 || colCount <= 1)
    {
        System.Console.WriteLine("Введено количество строк или столбцов меньше 1!");
        // Main();
    }
    else
    {
        int[,] matrix = GenerateMatrix(rowCount, colCount, 0, 9);
        PrintMatrix(matrix);
        string resultData = deleteMinRowColumn(matrix);
        int[,] changedMatrix = CreateResultMatrix(resultData, rowCount - 1, colCount - 1);
        PrintMatrix(changedMatrix);
    }
}

// создаем новую матрицу и заполняем из результирующей строки
int[,] CreateResultMatrix(string data, int rows, int cols)
{
    int[,] newMatrix = new int[rows, cols];
    int row = 0;
    int column = 0;
    System.Console.WriteLine(data);

    for (int i = 0; i < data.Length; i++)
    {
        newMatrix[row, column] = int.Parse(data[i].ToString());
        if (column == cols - 1)
        {
            row += 1;
            column = 0;
        }
        else { column += 1; }
    }
    return newMatrix;
}

// можно было в методе CreateResultMatrix использовать следующий принцип: 
// string text = "(1,2) (2,3) (4,5) (6,7)";
// var data = text.Split(" ").ToArray();
// for (int=0; i < data.Length; i++)
// {
//     System.Console.WriteLine(data[i]);
// }

// собираем нужные элементы матрицы (без элементов лишнего столбца и строки) в одну переменную типа string
// можно было в массив (array) длиной rows-1 * colimns-1
string deleteMinRowColumn(int[,] matrix)
{
    int numRows = matrix.GetLength(0);
    int numCols = matrix.GetLength(1);
    //int[,] changedMatrix = new int(numRows - 1, numCols - 1);

    int rowPosition = 0;
    int colPosition = 0;

    for (int i = 0; i < numRows; i++)
    {
        bool flag = false;
        for (int j = 0; j < numCols; j++)
        {
            if (matrix[i, j] == minValue(matrix))
            {
                rowPosition = i;
                colPosition = j;
                flag = true;
                break;
            }
        }
        if (flag) { break; }
    }
    string tempData = string.Empty;

    for (int i = 0; i < numRows; i++)
    {
        if (i == rowPosition) { continue; }
        else
        {
            for (int j = 0; j < numCols; j++)
                if (j == colPosition) { continue; }
                else
                {
                    tempData += matrix[i, j];
                }
        }
    }
    return tempData;
}

// находим элемент с минимальным значением в данной матрице
int minValue(int[,] matrix)
{
    int minDigit = matrix[0, 0];
    int numRows = matrix.GetLength(0);
    int numCols = matrix.GetLength(1);

    for (int i = 0; i < numRows; i++)
    {
        for (int j = 0; j < numCols; j++)
        {
            if (matrix[i, j] < minDigit) { minDigit = matrix[i, j]; }
        }
    }
    return minDigit;
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            // 
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

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();