// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matr = FillMatrix(3, 4, 1, 10);
PrintMatrix(matr);

 Console.WriteLine($"Cреднее арифметическое:");
for (int j = 0; j < 4;j++)
{
  double average = 0;
 
  for (int i = 0; i < 3; i++)
  {
    average += matr [i, j];
  
  }
  average = Math.Round(average/3, 1);

  Console.WriteLine($"столбца № {j}: {average}");
}

//******

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

}
   

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            matrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }

    return matrix;

}