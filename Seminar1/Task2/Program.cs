Console.Write("Введите 1-ое число: ");
 int num1 = int.Parse (Console.ReadLine());
 Console.Write("Введите 2-ое число: ");
 int num2 = int.Parse (Console.ReadLine());
 if (num1 > num2)
 {
     Console.WriteLine($"1-ое число ({num1}) больше");
 }
 else if (num2 > num1)
 {
     Console.WriteLine($"2-ое число ({num2}) больше");
 }
 else
 {
    Console.WriteLine("Введенные числа равны");
 }