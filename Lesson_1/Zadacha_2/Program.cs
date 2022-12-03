Console.WriteLine("Введи 2 числа и увидите какое больше, а какое меньше");
int a, b;
Console.WriteLine("Введи первое число:");
    a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число:");
    b = Convert.ToInt32(Console.ReadLine());
bool Rav0 = a > b;
bool Rav1 = a == b;
bool Rav2 = a < b;
    if (Rav0)
    {
        Console.WriteLine($"Число {a} больше чем {b}");
    }
    else if (Rav1)
    {
        Console.WriteLine($"Числа {a} и {b} равны");
    }
    else
    {
        Console.WriteLine($"Число {b} больше чем {a}");
    }