/*
Непоторяющиеся эл-ты. Логику с рекурсией понял, но есть пара моментов:
- вложенность циклов величиной в четыре - очень большая, рекомедовал бы что-то вынести в метод (например проверку эл-та на присутствие в массиве)
- вижу что если повтор найден, то элемент генерируется, вставляется и снова проверяется. 
Но хотелось бы чтобы вставляли эл-т, который уникальный и не присутствует в массиве. 
Если вставлять эл-т и проверять его только после вставки, то проходов по массиву может быть очень много.
*/

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] sizeArray = {m, n};
int[,] arr = FillArray(sizeArray);
PrintArray(arr);

int[,] FillArray(int[] sizeArray)
{
    int[,] array = new int[sizeArray[0], sizeArray[1]];    
    Random random = new Random();
    array[0,0] = random.Next(1,10);    
    int tmp = 0;
    for (int i = 0; i < sizeArray[0]; i++)
    {
        for (int j = 0; j < sizeArray[1]; j++)
        {
            if (i == 0 && j == 0) continue;
            tmp = random.Next(1, 100);           
            if (checkDuplicate(array, tmp)) j--;            
            else array[i, j] = tmp;
        }
    }
    return array;
}

bool checkDuplicate(int[,] arr, int num)
{   
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] == num) return true;
        }        
    }
    return false;    
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