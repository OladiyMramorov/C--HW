int m = 2;
int n = 2;
int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[m, n];
FillMatrix(matrix1);
FillMatrix(matrix2);
Console.WriteLine("Матрица один");
PrintArray(matrix1);
Console.WriteLine("Матрица два");
PrintArray(matrix2);
Console.WriteLine("Произведение двух матриц");
PrintArray(MatrixMultiplication(matrix1, matrix2));

void FillMatrix(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] arr1, int[,] arr2)
{
    int[,] MatrixMultiplication = new int[arr1.GetLength(0), arr2.GetLength(1)];
    if (arr1.GetLength(1) == arr2.GetLength(0))
    {
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                for (int k = 0; k < arr2.GetLength(0); k++)
                {
                    MatrixMultiplication[i, j] += arr1[i, k] * arr2[k, j];
                }
            }
        }
    }
    else
    {
        {
            Console.Write("вычислить невозможно");
        }
    }
    return MatrixMultiplication;
}