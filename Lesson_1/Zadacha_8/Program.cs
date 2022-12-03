Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 2;
if(num1 > 1)
{
    while(num2 <= num1)
    {
        Console.WriteLine(num2+ " ");
        num2 = num2 + 2;
    }
}