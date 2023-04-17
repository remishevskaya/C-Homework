Console.Write("Введите начальное значение ряда: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите начальное значение ряда: ");
int n = Convert.ToInt32(Console.ReadLine());

int RecSum(int m, int n)
{
    if (n == m) return m;
    return n + RecSum(m, n - 1);
}

Console.WriteLine(RecSum(m, n));