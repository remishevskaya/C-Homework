Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string SumNum(int num)
{
    int sum = 0;
    int num2 = num;
    string message = string.Empty;

    while (num != 0)
    {
        sum = sum + num % 10;
        num = num / 10;

    }

    message = $"Сумма цифр числа {num2} равна {sum}";
    return message;
}

Console.Write(SumNum(num));