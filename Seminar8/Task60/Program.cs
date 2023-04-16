Console.Write("Введите количество строк в 1 матрице: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк в 1 матрице: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк в 1 матрице: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int[,,] NumArray = new int[num1, num2, num3];

void FillArray(int[,,] array)
{
    SortedSet<int> List = new SortedSet<int>();
    for (int k = 0; k < 99; k++)
    {
        List.Add(k + 1);
    }
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = List.ElementAt<int>(new Random().Next(0, List.Count - 1));
                List.Remove(array[i, j, k]);

            }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[j, k, i],2} ({j}, {k}, {i}) \t");
            Console.WriteLine("");
        }
    }
}

FillArray(NumArray);
PrintArray(NumArray);