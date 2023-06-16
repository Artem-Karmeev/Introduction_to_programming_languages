//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int CountEvenNum(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}


Console.WriteLine("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + ", ");
}

int result = CountEvenNum(array);
Console.WriteLine($"Количество чётных чисел в массиве: {result}");