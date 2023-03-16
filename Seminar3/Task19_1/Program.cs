Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num / 10000 > 0 && num / 10000 < 10)
{
    Console.Write(NumPal(num));
}
else
{
    Console.Write("Число не пятизначное");
}

string NumPal(int num)
{
    string message = string.Empty;

    if (num % 10 == num / 10000 && num % 100 / 10 == num % 10000 / 1000)
        message = "Число является палиндромом";
    else
        message = "Число не является палиндромом";

    return message;
}
