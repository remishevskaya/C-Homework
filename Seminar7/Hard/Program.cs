Console.Write("Введите количество строк в массиве: ");
int str = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество колонок в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());

if (str * column % 2 != 0) Console.WriteLine("Количество элементов в массиве нечетное. Попробуйте еще раз.");

else
{

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
    int[,] ArrayCoord = new int[str, column];

    int str1;
    int str2;
    int column1;
    int column2;

    for (int i = 0; i < array.GetLength(0) * array.GetLength(1) / 2; i++)
    {
        while (true)
        {
            str1 = new Random().Next(0, array.GetLength(0));
            column1 = new Random().Next(0, array.GetLength(1));
            if (ArrayCoord[str1, column1] == 0)
            {
                ArrayCoord[str1, column1] = 1;
                break;
            }
        }
        while (true)
        {
            str2 = new Random().Next(0, array.GetLength(0));
            column2 = new Random().Next(0, array.GetLength(1));
            if (ArrayCoord[str2, column2] == 0)
            {
                ArrayCoord[str2, column2] = 1;
                break;
            }
        }
        (NumArray[str1, column1], NumArray[str2, column2]) = (NumArray[str2, column2], NumArray[str1, column1]);
        Console.WriteLine($"Итерация {i + 1}");
        PrintArray(NumArray);
        Console.WriteLine("");

    }
}

ArraySort(NumArray);
Console.WriteLine("");


PrintArray(NumArray);
}