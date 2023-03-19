Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
int deg = Convert.ToInt32(Console.ReadLine());

int Mult(int num, int deg)
{
    int result = 1;

    for (int i = 1; i <= deg; i++)
    {
        result = result * num;
    }
    
    return result;
}

Console.Write(Mult(num, deg));