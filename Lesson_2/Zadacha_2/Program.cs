Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 99)
{
    Console.WriteLine("Третья цифра: " + (num / 100) % 10);
}
else
{
    Console.Write("Третьей цифры нет: ");
}
//Математический все верно вроде, но все равно не могу понять в чем моя ошибка!