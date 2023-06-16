// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int t = 0; t < array.GetLength(1) - 1; t++)
            {
                if (array[i, t] < array[i, t + 1])
                {
                    int temp = 0;
                    temp = array[i, t];
                    array[i, t] = array[i, t + 1];
                    array[i, t + 1] = temp;
                }
            }
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите кол-во строк : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[x, y];

FillArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);