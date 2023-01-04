/*
Непоторяющиеся эл-ты. Логику с рекурсией понял, но есть пара моментов:
- вложенность циклов величиной в четыре - очень большая, рекомедовал бы что-то вынести в метод (например проверку эл-та на присутствие в массиве)
- вижу что если повтор найден, то элемент генерируется, вставляется и снова проверяется. 
Но хотелось бы чтобы вставляли эл-т, который уникальный и не присутствует в массиве. 
Если вставлять эл-т и проверять его только после вставки, то проходов по массиву может быть очень много.
*/
Console.WriteLine("Введите размер массива m*n (но не более чем 9*10)");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];
FillArray(arr);
PrintArray(arr);
GetNumbers(arr);
Console.WriteLine();

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