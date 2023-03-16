Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());

void Cube(int num)
{
    for (int i = 1; i <= num; i++)
        Console.WriteLine(i * i * i);
}

Cube(num);