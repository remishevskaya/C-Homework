double[,] Array = new double[3, 4];


void FillArray(double[,] array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
        for (int j = 0; j < Array.GetLength(1); j++)
            Array[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(-100, 101), 1);
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
            Console.Write($"{Array[i, j],4} \t");
        Console.WriteLine("");
    }
}

FillArray(Array);
PrintArray(Array);