// Задача 64: Задайте значение N. 
// Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

int GetNum(int n)
{

    if (n == 1)
    {
        return 1;
    }
    Console.WriteLine(n);
    return GetNum(n - 1);
}

Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int f = GetNum(n);
Console.WriteLine(f);