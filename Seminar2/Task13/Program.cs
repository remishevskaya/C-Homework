Console.Write("Введите число: ");
int num1 = int.Parse (Console.ReadLine());
int num2 = num1;
int count = 1;
int div = 1;

if (num1 / 100 > 0)
{
    while (num2 / 10 != 0)
    {
        num2 = num2 / 10;
        count++;
    }
    while (count > 3)
    {
        div = div * 10;
        count = count - 1;
    }
    Console.WriteLine(num1 / div % 10);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
