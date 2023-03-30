int[] RandArray = new int[new Random().Next(1, 20)];
int even = 0;


string ElemEven(int[] array)
{
    string message = string.Empty;

    foreach (int i in RandArray)
    {
        if (i % 2 == 0) even = even + 1;
    }

    message = $"Количество четных элементов: {even}";

    return message;
}

Console.WriteLine(ElemEven(RandArray));