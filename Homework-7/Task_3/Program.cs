// Задача 52. Запросите от пользователя размерности двумерного массива. 
//Напишите метод для заполнения массива случайными числами. 
//Напишите метод для поиска ср. арифметического значения каждого столбца.
Console.Clear();

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + "; ");
        }
        Console.WriteLine();
    }
}

void GetArithmeticMean(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j, i];
        }
        Console.Write(sum / array.GetLength(1) + "; ");
    }
}

Console.WriteLine("Введите длинну строки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во строк: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[x, y];

FillArray(array);
Console.WriteLine();
GetArithmeticMean(array);


