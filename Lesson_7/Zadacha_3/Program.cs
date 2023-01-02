void RandomArray(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(100, 1000);
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

void GetArithmeticMeanAmongPalindromes(int[,] arr)
{
    double[] array = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int countPolydromes = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            if (arr[j, i] / 100 == arr[j, i] % 10)
            {
                array[i] += arr[j, i];
                countPolydromes++;
            }
        }
        if (countPolydromes == 0)
        {
            array[i] = 0;
        }
        else
        {
            array[i] = Math.Round(array[i] / countPolydromes, 2);
        }
    }

    Console.WriteLine("Cреднее арифметическое среди тех элементов, которые являются палиндромами");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
    }
}

int m = 5;
int n = 5;
int[,] array = new int[m, n];
RandomArray(array);
PrintArray(array);
GetArithmeticMeanAmongPalindromes(array);