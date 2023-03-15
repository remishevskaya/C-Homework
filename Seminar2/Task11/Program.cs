Console.Write("Введите число: ");
int num = int.Parse (Console.ReadLine());
int num2 = num;
int count = 1;
int mult = 1;
int num3 = 0;

while (num2 / 10 != 0)
{
    num2 = num2 / 10;
    count++;
}

while (count > 0)
{
    if (count != 2)
    {
        num3 = num3 + num % 10 * mult;
        mult = mult * 10;
    }
    num = num / 10;
    count = count - 1;
}

Console.WriteLine(num3);