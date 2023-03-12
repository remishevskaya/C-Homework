Console.Write("Введите число: ");
int num = int.Parse (Console.ReadLine());
int count = 1;

while (count < num + 1)
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);
    }
    count = count + 1;
}
