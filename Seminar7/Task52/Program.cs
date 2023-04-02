Console.Write("Введите количество строк в массиве: ");
int str = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество колонок в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] NumArray = new int[str, column];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 101);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],2} \t");
        Console.WriteLine("");
    }
}

FillArray(NumArray);
PrintArray(NumArray);

void AvColums(int[,] array)
{
    double[] AvArray = new double[column];
    double sum = 0;

    for (int i = 0; i < NumArray.GetLength(1); i++)
    {
        for (int j = 0; j < NumArray.GetLength(0); j++)
        {
            sum = sum + NumArray[j, i];
        }
        AvArray[i] = Math.Round(sum / NumArray.GetLength(0), 1);
        sum = 0;
    }

    for (int i = 0; i < AvArray.Count(); i++)
        Console.WriteLine($"Среднее арифметическое столбца {i + 1}: {AvArray[i]}");
}

AvColums(NumArray);