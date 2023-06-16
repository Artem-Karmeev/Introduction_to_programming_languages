/* Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет. */

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99) 
{
    while (num > 1000)
{
    num = (num / 10);
}
    num = num % 10;

Console.WriteLine(num);
}
else 
{
    Console.WriteLine("Третьей цифры нет.");
}