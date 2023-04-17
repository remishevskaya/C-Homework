Console.Write("Введите начальное значение ряда: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите начальное значение ряда: ");
int n = Convert.ToInt32(Console.ReadLine());

int AkkFunction(int m, int n)
{
    if(m == 0) return n + 1;
    else if (m > 0 & n == 0) return AkkFunction(m - 1, 1);
    else return AkkFunction(m - 1, AkkFunction(m, n - 1));
}

Console.WriteLine(AkkFunction(m, n));
