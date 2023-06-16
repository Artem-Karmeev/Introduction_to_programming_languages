//Задача 50. Напишите программу, 
//которая будет принимать от пользователя позицию (M, N) двумерного массива и возвращать значение элемента, 
//стоящего в этой позиции. Если такой позиции в массиве нет, то сообщить об этом пользователю. 
//Сгенерировать массив случайным образом. 
//Размерность массива определить самостоятельно. 
//Использование методов для заполнения массива обязательно. 
//Остальное можно реализовать в главной программе.
Console.Clear();

void FillArray(int[,] array)
{
   for(int i = 0; i < array.GetLength(0); i++)
   {
       for(int j = 0; j < array.GetLength(1); j++)
       {
          array[i, j] = new Random().Next(1, 1000);
       }
   }
}

int x = new Random().Next(1, 51);
int y = new Random().Next(1, 51);
int [,] array = new int[x, y];
FillArray(array);

Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (m >= x || n >= y)
{
    Console.WriteLine("Такой позиции нет((.");
}
else 
{
    Console.WriteLine(array[m, n]);
}
