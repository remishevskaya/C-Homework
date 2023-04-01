Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] NumArray = new int[size];

string SumPos(int[] array)
{
    string message = string.Empty;
    int sumPos = 0;

    for (int i = 0; i < NumArray.Length; i++)
    {
        Console.Write($"Введите {i + 1} число массива: ");
        NumArray[i] = Convert.ToInt32(Console.ReadLine());
    }

    foreach (int i in NumArray)
    {
        Console.Write($"{i} ");
        if (i > 0) sumPos++;
    }

    message = $"Количество положительных чисел в массиве: {sumPos}";

    return message;
}

Console.WriteLine($"\n{SumPos(NumArray)}");