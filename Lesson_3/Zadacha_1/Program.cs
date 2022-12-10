int num = 0;
while (true)
{
    Console.Write("Введите число: ");
    if (int.TryParse(Console.ReadLine(), out num) && (num < 99999))
        break;
    else 
        Console.WriteLine("Программа принимает только пятизначное число");
}
int oldNum = num;
int newNum = 0;
while (num > 0)
{
    int x = num % 10;
    newNum = newNum * 10 + x;
    num = num / 10;
}
if (newNum == oldNum)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}
        