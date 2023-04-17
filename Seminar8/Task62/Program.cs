int[,] NumArray = new int[4, 4];

void FillArray(int[,] array)
{
    array[0, 0] = 1;
    for (int n = 0; n < array.GetLength(0) * array.GetLength(1); n++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == 0 & j != 0) array[i, j] = array[i, j - 1] + 1;
                else if (i != 0 & j == array.GetLength(1) - 1) array[i, j] = array[i - 1, j] + 1;
                else if (i == array.GetLength(0) - 1 & j != array.GetLength(1) - 1) array[i, j] = array[i, j + 1] + 1;
                else if (j == 0 & i != 0 & i != array.GetLength(0) - 1) array[i, j] = array[i + 1, j] + 1;
                else if (i == 1 & j != array.GetLength(1) - 1 & j != 0) array[i, j] = array[i, j - 1] + 1;
                else if (i == 2 & j != array.GetLength(1) - 1 & j != 0 & j == 2) array[i, j] = array[i - 1, j] + 1;
                else if (i == 2 & j != array.GetLength(1) - 1 & j != 0 & j != 2) array[i, j] = array[i, j + 1] + 1;
            }
    }

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