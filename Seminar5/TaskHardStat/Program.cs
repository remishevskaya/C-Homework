int[] RandArray = new int[new Random().Next(1, 20)];

string ArrayOptions(int[] array)
{
    int[] ArrayOpt = new int[6];
    int sum = 0;
    int med = 0;
    string message = string.Empty;

    for (int i = 0; i < RandArray.Length; i++) RandArray[i] = new Random().Next(1, 356);

    for (int i = 0; i < RandArray.Length; i++) sum = sum + RandArray[i];

    ArrayOpt[0] = RandArray.Max();
    ArrayOpt[1] = Array.IndexOf(RandArray, RandArray.Max());
    ArrayOpt[2] = RandArray.Min();
    ArrayOpt[3] = Array.IndexOf(RandArray, RandArray.Min());
    ArrayOpt[4] = sum / RandArray.Length;

    Array.Sort(RandArray);

    if (RandArray.Count() % 2 == 0) med = (RandArray[RandArray.Count() / 2] + RandArray[RandArray.Count() / 2 + 1]) / 2;
    else med = RandArray[RandArray.Count() / 2];

    ArrayOpt[5] = med;

    message = $"Максимальное значение массива {ArrayOpt[0]}, индекс максимального значения {ArrayOpt[1]} \nМинимальное значение массива {ArrayOpt[2]}, индекс минимального значения {ArrayOpt[3]} \nСреднее арифметическое {ArrayOpt[4]} \nМедианное значение {ArrayOpt[5]}";
    return message;
}

Console.Write(ArrayOptions(RandArray));