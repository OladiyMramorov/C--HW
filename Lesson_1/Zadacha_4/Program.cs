Console.WriteLine("Введите 3 числа и получите максимальное из них");
int a, b, c, max;
Console.WriteLine("Введи первое число:");
    a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число:");
    b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи третье число:");
    c = Convert.ToInt32(Console.ReadLine());
max = a;
if (b > a)
    max = b;
if (c > max)
    max = c;
Console.WriteLine($"Число {max} максимальное из 3");