Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 99 && num < 999)
{
    Console.WriteLine("Третья цифра: " + (num / 10) % 10);
}
else
{
    Console.Write("Только трехзначное число");
}
