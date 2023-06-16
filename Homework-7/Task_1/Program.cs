//Задача 47. Запросите от пользователя размерности двумерного массива. 
//Напишите метод для заполнения массива случайными числами. 
//Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво).
//Округлите значения, генерируемые Random до двух знаков после запятой.
Console.Clear();

 void FillArray(double[,] array)
 {
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() + new Random().Next(1, 10);
        }
    }
 }

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i, j], 2) + "; ");
        }
    Console.WriteLine();
    }
}

Console.WriteLine("Введите длинну строки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во строк: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double [,] array = new double[x, y];

FillArray(array);
PrintArray(array);
