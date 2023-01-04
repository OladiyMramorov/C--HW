int m = 5;
int n = 5;
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
GetNumbers(array);
Console.WriteLine();
PrintArray(array);

void FillArray(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(10, 100);
        }
    }
}

void GetNumbers(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int l = 0; l < arr.GetLength(0); l++)
            {
                for (int k = 0; k < arr.GetLength(1); k++)
                {
                    if (arr[i, j] == arr[l, k])
                    {
                        if (k != j && i != l)
                        {
                            arr[i, j] = new Random().Next(10, 100);
                            GetNumbers(arr);
                        }
                    }
                }
            }
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