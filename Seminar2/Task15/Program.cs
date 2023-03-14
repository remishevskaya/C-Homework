Console.Write("Введите номер дня недели: ");
int day = int.Parse (Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("Нет");
        break;
    case 2:
        Console.WriteLine("Нет");
        break;
    case 3:
        Console.WriteLine("Нет");
        break;
    case 4:
        Console.WriteLine("Нет");
        break;
    case 5:
        Console.WriteLine("Нет");
        break;
    case 6:
        Console.WriteLine("Да");
        break;
    case 7:
        Console.WriteLine("Да");
        break;
    default:
        Console.WriteLine("Дня недели с таким номером не существует");
        break;
}