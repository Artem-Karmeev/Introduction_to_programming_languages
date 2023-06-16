/*Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.*/

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int a = 0;

if (n % 2 == 0) 
{
while (a < n)
{
    a = a + 2;
    Console.WriteLine(a);
}
}
else 
{
    n = n - 1;
    while (a < n)
{
    a = a + 2;
    Console.WriteLine(a);
}
}