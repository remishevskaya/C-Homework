Console.Write("Введите 1-ое число: ");
int num1 = int.Parse (Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int num2 = int.Parse (Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int num3 = int.Parse (Console.ReadLine());

int num_max = num1;

if (num2 > num_max)
{
    num_max = num2;
}
    if (num3 > num_max)
    {
        num_max = num3;
    }

Console.Write($"Максимальное число: {num_max}");