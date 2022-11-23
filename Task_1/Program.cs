Console.Write("Введите пожалуйста первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите пожалуйста второе число: ");
int b = int.Parse(Console.ReadLine());
if (a > b)
    Console.Write("Первое число, больше чем второе.");
else if (a < b)
    Console.Write("Второе число, больше чем первое.");
else if (a == b)
    Console.Write("Числа равны");