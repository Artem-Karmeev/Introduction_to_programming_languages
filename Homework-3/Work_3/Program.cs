/*Задача 23: Напишите программу,
 которая принимает на вход число (N) 
 и выдаёт таблицу кубов чисел от 1 до N.*/

void PrintCubToNamber(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"Куб Числа {i} = {i * i * i}");
    }
}

Console.WriteLine("введи число: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintCubToNamber(n);