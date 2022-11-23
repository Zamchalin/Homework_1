Console.Write("Введите пожалуйста  число: ");
int a = int.Parse(Console.ReadLine());
int i = 1;
while (i <= a)
if (i % 2 == 0)
{
    Console.Write($"{i} ");
    i++;
}
else {
    i++;
}