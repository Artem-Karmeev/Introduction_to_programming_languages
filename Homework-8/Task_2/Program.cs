// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "; ");
        }
        Console.WriteLine();
    }
}

int SearchMinSumSrt(int[,] array)
{
    int minSumStr = 0;
    int indexMinStr = 0;


    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSumStr = minSumStr + array[0, j];
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sumStr = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumStr = sumStr + array[i, j];
        }
        if (sumStr < minSumStr)
        {
            minSumStr = sumStr;
            indexMinStr = i;
        }
    }
    return indexMinStr;
}

Console.WriteLine("Введите кол-во строк : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[x, y];

FillArray(array);
PrintArray(array);
int indexMinSumStr = SearchMinSumSrt(array);
Console.WriteLine(indexMinSumStr);



