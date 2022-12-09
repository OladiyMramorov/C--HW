Console.Write("Введиче число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)
{
    Console.Write("Число кратно 7 и 23");
}
else
{
    Console.Write("Число не кратно 7 и 23");
}