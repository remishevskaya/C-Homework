Console.Write("Введите число, которое нужно найти в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());

int[,] NumArray = new int[,]
{
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
};

void IfNumInArray(int num)
{
    string message = String.Empty;

    for (int i = 0; i < NumArray.GetLength(0); i++)
        for (int j = 0; j < NumArray.GetLength(1); j++)
            if (NumArray[i, j] == num) Console.WriteLine(message = $"Позиция данного числа: {i}, {j}");
    if (message == String.Empty) Console.WriteLine("Данного числа в массиве нет");
}

IfNumInArray(num);