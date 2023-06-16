// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

uint GetAckerman(uint n, uint m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else
    {
        if ((n != 0) && (m == 0))
        {
            return GetAckerman(n - 1, 1);
        }
        else
        {
            return GetAckerman(n - 1, GetAckerman(n, m - 1));
        }
    }
}

Console.WriteLine("Введите M: ");
uint m = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
uint n = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine(GetAckerman(m, n));