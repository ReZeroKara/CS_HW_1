//Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

int count1 = 0;
int count2 = n - 1;
int a = 0;

while(count1 < count2)
{
    int result = 2 + a;
    Console.Write(result + ", ");
    a += 2;
    count1 += 2;
}