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

void MinStroke(int[,] array)
{
    int sumStroke = 0;
    int minSum = 10000;
    int numStroke = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumStroke = sumStroke + NumArray[i, j];
        }
        if (sumStroke < minSum)
        {
            minSum = sumStroke;
            numStroke = i;
        }
        sumStroke = 0;
    }
    Console.WriteLine($"Наименьшая сумма {numStroke + 1} строки: {minSum}");
}

Console.WriteLine("");
MinStroke(NumArray);