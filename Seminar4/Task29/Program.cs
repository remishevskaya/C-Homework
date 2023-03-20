Console.Write("Введите длину массива: ");
int ArrayLength  = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение массива: ");
int ArrayMin  = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение массива: ");
int ArrayMax  = Convert.ToInt32(Console.ReadLine());

void ArrayGen (int ArrayLength, int ArrayMin, int ArrayMax)
{
    int [] NewArray = new int[ArrayLength];

    for (int i = 0; i < ArrayLength; i++)
    {
        NewArray [i] = new Random().Next(ArrayMin, ArrayMax + 1);
    }
    for (int i = 0; i < ArrayLength; i++)
    {
        Console.WriteLine(NewArray[i]);
    }
    
}

ArrayGen(ArrayLength, ArrayMin, ArrayMax);