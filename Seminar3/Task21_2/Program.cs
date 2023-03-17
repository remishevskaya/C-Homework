Console.Write("Введите количество измерений для пространства: ");
int meas = Convert.ToInt32(Console.ReadLine());

double KoordDist(int meas)
{
    int[] koord1 = new int[meas];
    int[] koord2 = new int[meas];
    double dist = 0;

    for (int i = 0; i < meas; i++)
    {
        Console.WriteLine($"Введите {i + 1} координату первой точки: ");
        int koord = Convert.ToInt32(Console.ReadLine());
        koord1[i] = koord;
    }

    for (int i = 0; i < meas; i++)
    {
        Console.WriteLine($"Введите {i + 1} координату второй точки: ");
        int koord = Convert.ToInt32(Console.ReadLine());
        koord2[i] = koord;
    }

    for (int i = 0; i < meas; i++)
    {
        dist = dist + (koord2[i] - koord1[i]) * (koord2[i] - koord1[i]);
    }

    return Math.Sqrt(dist);
}

Console.Write($"Расстояние между точками: {KoordDist (meas)}");