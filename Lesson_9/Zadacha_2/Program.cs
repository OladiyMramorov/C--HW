Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum;
if (m<n)
{
    sum = SumNaturalElements(m, n);
}
else
{
    sum = SumNaturalElements(n, m);
}
Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} = {sum}");

int SumNaturalElements(int m, int n)
{
    if (m <= n){
        return m+SumNaturalElements(m+1,n);
    }
    else{
        return 0;
    }
}