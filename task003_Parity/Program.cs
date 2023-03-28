//Программа определяет, чётное число или нет.

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int b = a % 2;

if (b == 0)
{
    Console.WriteLine("Число является чётным!");
}
else
{
    Console.WriteLine("Число не является чётным!");
}