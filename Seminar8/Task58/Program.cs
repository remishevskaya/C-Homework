Console.Write("Введите количество строк в 1 матрице: ");
int str1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество колонок в 1 матрице: ");
int column1 = Convert.ToInt32(Console.ReadLine());

int[,] Matrix1 = new int[str1, column1];

Console.Write("Введите количество строк во 2 матрице: ");
int str2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество колонок во 2 матрице: ");
int column2 = Convert.ToInt32(Console.ReadLine());

int[,] Matrix2 = new int[str2, column2];


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

FillArray(Matrix1);
FillArray(Matrix2);
Console.WriteLine("1 матрица");
PrintArray(Matrix1);
Console.WriteLine("2 матрица");
PrintArray(Matrix2);

void MatrixComposition(int[,] array1, int[,] array2)
{
    int[,] CompMatrix = new int[str1, column2];
    if (column1 != str2) Console.WriteLine("Невозможно найти произведение матриц, так как число колонок 1 матрицы не равно числу строк 2 матрицы");
    else
    {
        for (int l = 0; l < array2.GetLength(1); l++)
        {
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++) CompMatrix[i, l] = CompMatrix[i, l] + array1[i, j] * array2[j, l];
            }
        }
        Console.WriteLine("Произведение матриц:");
        PrintArray(CompMatrix);
    }

}


MatrixComposition(Matrix1, Matrix2);