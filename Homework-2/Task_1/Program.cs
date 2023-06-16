/* Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.*/

Console.WriteLine("Введите трёхзначное число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1000 && num > 99)
{
int n1 = num % 100;
int n2 = n1 / 10;
Console.WriteLine(n2);
}
else
{
    Console.WriteLine("Число должно быть трехзначным");
}