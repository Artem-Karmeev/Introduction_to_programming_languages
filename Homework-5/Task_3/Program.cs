// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76


double SearchMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];


    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        if (min > array[i])
        {
            min = array[i];
        }
    }
    double result = max - min;
    return result;
}

Console.WriteLine("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = new double[size];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble() + new Random().Next(-999, 1000);
    Console.Write(array[i] + ";  ");
}

double res = SearchMaxMin(array);
Console.WriteLine();
Console.WriteLine($"Разница между минимальным и максимальным значением:  {res}");

