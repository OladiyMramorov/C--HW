Console.Write("Введите колличество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите числа через запятую: ");
List<int> numbers = Console.ReadLine().Split(',').Select(Int32.Parse).ToList();
int sum = 0;
for (int i = 0; i < m; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"Чисел больше 0 = {sum}");
