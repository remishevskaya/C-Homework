double[] RandArray = new double[10];
double dif = 0;

double DifArray(double[] array)
{
    for (int i = 0; i < RandArray.Count(); i++)
    {
        RandArray[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }

    dif = RandArray.Max() - RandArray.Min();

    return dif;
}

Console.WriteLine(DifArray(RandArray));