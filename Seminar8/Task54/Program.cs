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

void ArraySort(int[,] array)
{
    for (int n = 0; n < NumArray.GetLength(1) * NumArray.GetLength(0); n++)
    {
        for (int i = 0; i < NumArray.GetLength(0); i++)
        {
            for (int j = 0; j < NumArray.GetLength(1); j++)
            {
                if (j != NumArray.GetLength(1) - 1)
                if (NumArray[i, j] < NumArray[i, j + 1]) (NumArray[i, j], NumArray[i, j + 1]) = (NumArray[i, j + 1], NumArray[i, j]);
            }
        }
    }
}

Console.WriteLine("");
ArraySort(NumArray);
PrintArray(NumArray);