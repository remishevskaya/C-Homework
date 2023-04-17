Console.Write("Введите начальное значение ряда: ");
int num = Convert.ToInt32(Console.ReadLine());

string RecPrint(int num)
{
    if (num == 1) return Convert.ToString(num);
    return num + " " + RecPrint(num - 1);
}

Console.WriteLine(RecPrint(num));