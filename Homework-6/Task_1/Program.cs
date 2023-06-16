//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("введите количество чисел, которое которое необходимо проветрить: ");
int size = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите значение № {i + 1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] >= 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество чисел больше нуля: {count} ");