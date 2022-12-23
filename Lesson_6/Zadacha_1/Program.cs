Console.Write("Введите числа через запятую: ");
int[] num = StringToNum(Console.ReadLine());
PrintArray(num);
int sum = 0;
for (int i = 0; i < num.Length; i++)
{
    if (num[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sum}");
int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }
    int[] num = new int [count];
    int index = 0;
    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";
        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        num[index] = Convert.ToInt32(temp);
        index++;
    }
    return num;
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}