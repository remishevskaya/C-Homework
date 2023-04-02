Console.Write("Введите k1 для 1 прямой (y1 = k1 * x + b1): ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1 для 1 прямой (y1 = k1 * x + b1): ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2 для 2 прямой (y2 = k2 * x + b2): ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2 для 2 прямой (y2 = k2 * x + b2): ");
double b2 = Convert.ToInt32(Console.ReadLine());

string LineIntersect(double k1, double k2, double b1, double b2)
{
    string message = String.Empty;

    if (k1 == k2)
    {
        if (b1 == b2)
        {
            message = "Прямые совпадают";
        }

        message = "Прямые параллельны";
    }
    else
    {
        double xInter = (b2 - b1) / (k1 - k2);
        double yInter = k2 * ((b2 - b1) / (k1 - k2)) + b2;

        message = $"Координата точки пересечения прямых {xInter}, {yInter}";
    }
    return message;
}

Console.Write(LineIntersect(k1, k2, b1, b2));