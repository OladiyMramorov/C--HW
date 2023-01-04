Console.Write("Введите количество строк: ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int minsum = Int32.MaxValue;
int indexLine = 0;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}

Console.WriteLine("Cтрока с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum));

void FillArrayRandomNumbers(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}