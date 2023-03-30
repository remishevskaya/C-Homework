int[] RandArray = new int[4];

string ArraySum(int [] array)
{
    int sum = 0;
    string message = string.Empty;

    for (int i = 0; i < RandArray.Length; i++) RandArray[i] = new Random().Next(-99, 101);

    foreach (int i in RandArray)
    {
        if (Array.IndexOf(RandArray, i) % 2 != 0) sum = sum + i;
    }
    message = $"Сумма чисел с нечетным индексом: {sum}";
    return message;
}


Console.WriteLine(ArraySum(RandArray));