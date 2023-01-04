Console.Write("Введите N: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(NaturalNumbersBetweenNandOne(num));
int NaturalNumbersBetweenNandOne(int n)
{
    if (n == 1)
    {
        return 1;
    }
    else
    {
        Console.Write(n + " ");
        return NaturalNumbersBetweenNandOne(n - 1);
    }

}