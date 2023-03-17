Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void NumPal(int num)
{
    int count = 1;
    int num2 = num;
    int check = 0;
    while (num / 10 != 0)
    {
        num = num / 10;
        count++;
    }

    int[] number1 = new int[count];

    for (int i = 0; i < count; i++)
    {
        number1[i] = num2 % 10;
        num2 = num2 / 10;
    }
››
    for (int i = 0; i <= number1.Length / 2; i++)
    {
        if (number1[i] == number1[(number1.Length - 1) - i])
        {
            check = check + 1;
        }
    }
    if (check == (count / 2) + 1)
    {
        Console.Write("Число является палиндромом");
    }
    else
    {
        Console.Write("Число не является палиндромом");
    }
}

NumPal(num);