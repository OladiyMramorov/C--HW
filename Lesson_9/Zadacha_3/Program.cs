Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m < 0 || n < 0)
{
    Console.WriteLine("Одно или оба числа отрицательные");
}
else
{
    Console.WriteLine($"A({m},{n}) = {FunctionAckerman(m, n)}");
}

int FunctionAckerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return FunctionAckerman(m - 1, 1);
    }
    else
    {
        return FunctionAckerman(m - 1, FunctionAckerman(m, n - 1));
    }
}

