/*Задача 25: Напишите программу, которая принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
Для решения задания использование цикла for является обязательным условием. 
Не использовать встроенный метод возведения в степень.

3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine("Задайте значение A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение В: ");
int b = Convert.ToInt32(Console.ReadLine());


int result = a;

for (int i = 0; i < b - 1; i++)
{
    result = result * a;
}

    Console.WriteLine($" {a} в степени {b} равно {result} ");

