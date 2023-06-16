/* Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.*/

Console.WriteLine("Введите цифру от 1 до 7 и вы узнаете какой это день ");
int num = Convert.ToInt32(Console.ReadLine());


if (num < 8 && num > 0) 
{
    if (num == 6 || num == 7 )
{
    Console.WriteLine("Выходной. ");
}
else
{
    Console.WriteLine("Будний. ");
}
}
else
{
Console.WriteLine("ERROR - нужно ввести число от одного до семи");
}
