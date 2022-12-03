

int InputData(string text)
{
    int n = -1;
    bool check = false;
    while (!check)
    {
        Console.Write($"Введите {text}: ");
        string data = Console.ReadLine();
        check = int.TryParse(data, out n);
    }
    return n;
}

int[,] CreateMatrix(int row, int column) { return new int[row, column]; }

int[,] FillMatrix(int[,] matrix, int min, int max)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

int[,] SortMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    
    int[,] res = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++) res[i,j] = matrix[i,j];
    }
    
    int max;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns - 1; j++)
        {
            
            for (int k = j + 1; k < columns; k++)
            {
                if (res[i, k] > res[i, j])
                {
                    max = res[i, k];
                    res[i, k] = res[i, j];
                    res[i, j] = max;
                }
            }
        }
    }
    return res;
}

void PrintResult(int[,] before, int[,] after)
{
    Console.WriteLine("Исходная матрица:");
    int r = before.GetLength(0);
    int c = before.GetLength(1);
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            Console.Write($" {before[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("Отсортированная матрица:");
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            Console.Write($" {after[i, j]} ");
        }
        Console.WriteLine();
    }
}

int rows = InputData("кол-во строк");
int columns = InputData("кол-во столбцов");
int lBound = InputData("нижний предел матрицы");
int uBound = InputData("верхний предел матрицы");
int[,] matrix = CreateMatrix(rows, columns);
matrix = FillMatrix(matrix, lBound, uBound);
int[,] result = SortMatrix(matrix);
PrintResult(matrix, result);