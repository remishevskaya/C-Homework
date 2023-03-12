Console.Write("Введите число: ");
int num = int.Parse (Console.ReadLine());

int num_left = num / 10 % 10;

if (num_left == 0)
{
    Console.Write("Нет");
}
else
{
    Console.Write(num_left);
}