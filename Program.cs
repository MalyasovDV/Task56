int LineSum(int[,] matrix, int i)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); ++j)
        sum += matrix[i,j];
    return sum;
}

int IndexMinLine(int[,] matrix)
{
    int minLineIndex = 0;
    int[] sums = new int[matrix.GetLength(0)];

    for (int i = 0; i < sums.GetLength(0); ++i)
        sums[i] = LineSum(matrix, i);

    for (int i = 1; i < sums.GetLength(0) - 1; ++i)
        if (sums[minLineIndex] > sums[i])
           {
            minLineIndex = i;
           }

    return minLineIndex;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
                Console.Write(matrix[i,j] + "  ");
            Console.WriteLine();
        }
    Console.WriteLine();
}

void MatrixInitialization(ref int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix.GetLength(1); ++j)
            matrix[i,j] = rnd.Next(-10, 10);
                
        
}


Console.WriteLine("Введите размеры матрицы");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[m,n];

MatrixInitialization(ref matrix);

Console.WriteLine("\nМатрица");
PrintMatrix(matrix);

Console.WriteLine("\nИндекс минимальной строки - {0}", IndexMinLine(matrix));