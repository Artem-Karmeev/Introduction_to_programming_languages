// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

int GetNum(int m, int n)
{

    if (n == m)
    {
        return n;
    }
    Console.WriteLine(n);
    return GetNum(m, n - 1);
}

Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int f = GetNum(m, n);
Console.WriteLine(f);