Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
int sum;
if (n<m)
{
    sum = SumNaturalElements(n, m);
}
else
{
    sum = SumNaturalElements(m, n);
}
Console.WriteLine($"Сумма натуральных элементов в промежутке от {n} до {m} = {sum}");

int SumNaturalElements(int n, int m)
{
    if (n <= m){
        return n+SumNaturalElements(n+1,m);
    }
    else{
        return 0;
    }
}