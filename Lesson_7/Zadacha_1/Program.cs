Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = RandomArray(m, n);
PrintArray(array);
double[,] RandomArray(int m, int n)
{
    double[,] array = new double[m,n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i,j] = Math.Round(random.NextDouble() * 10, 2);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)        
        {
            if (j == 0) Console.Write(array[i,j]);
            else Console.Write("; " + array[i,j]);
        }
        Console.WriteLine();
    }
}