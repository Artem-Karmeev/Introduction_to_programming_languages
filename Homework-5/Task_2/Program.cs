// Задача 36: Задайте одномерный массив, 
//заполненный случайными числами. Найдите сумму элементов,
//стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int FindSumOfEvenCells(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}


Console.WriteLine("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i] + ", ");
}

int result = FindSumOfEvenCells(array);
Console.WriteLine($"Сумма элементов с нечетным индексом: {result}");