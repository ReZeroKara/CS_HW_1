//Программа принимает на вход два числа и выдаёт, какое из них больше, а какое меньше.

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Max: " + a);
    Console.WriteLine("Min: " + b);
}
else if (b > a)
{
    Console.WriteLine("Max: " + b);
    Console.WriteLine("Min: " + a);
}
else if (a == b)
{
    Console.WriteLine("Числа равны!");
}
else
{
    Console.WriteLine("Некорректный ввод!");
}