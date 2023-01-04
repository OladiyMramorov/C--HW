/*Строка с наименьшей суммой элементов. Согласен с подходом, именование методов удачное. 
Но не могу согласиться с ответом, поскольку номер строки измениется только на строке 20 (скрин теста приладываю)*/


Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];
FillArrayRandomNumbers(arr);
PrintArray(arr);
int indexLine = -1;
int minsum = Int32.MaxValue;
for (int i = 0; i<arr.GetLength(0); i++){
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++){
        sum += arr[i,j];
    }
    if (sum < minsum){
        minsum = sum;
        indexLine = i+1;
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