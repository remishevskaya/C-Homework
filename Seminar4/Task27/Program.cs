Console.Write("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());

decimal num2 = Convert.ToDecimal(num);


decimal sum = 0;

decimal SumNum(decimal num2)
{
    while (num2 >= 1)
    {
        sum = sum + (num2 % 10);
        num2 = Math.Truncate(num2 / 10);

    }


    if (sum - Math.Truncate(sum) > 0)
    {
        num2 = sum - Math.Truncate(sum);
        sum = Math.Truncate(sum);

        while (num2 > 0)
        {
            sum = sum + Math.Truncate(num2 * 10 % 10);
            num2 = num2 * 10 - Math.Truncate(num2 * 10);
        }
    }
    return sum;
}


Console.WriteLine(SumNum(num2));


