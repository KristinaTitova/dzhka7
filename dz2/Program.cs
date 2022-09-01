// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine()); 

int[,] matr = FillMatrix(3, 4, 1, 10);
PrintMatrix(matr);

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
        
    }
    
    if (m>matrix.GetLength(0) || n>matrix.GetLength(1))
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine(matrix[m,n]);
    }

}

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}