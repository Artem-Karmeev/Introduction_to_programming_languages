// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.

/*
В решение внесены правки, добавил подпрограмму 
для заполнения генератором псевдослучайных чисел,
изначально программа выглядела так:

void FillArray(int[,,] array)
	{
	    int xD = 10;
	

	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            for (int z = 0; z < array.GetLength(2); z++)
	            {
	                array[i, j, z] = xD;
	                xD++;
	            }
	        }
	    }
	}
	

	void PrintArray(int[,,] array)
	{
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            for (int z = 0; z < array.GetLength(2); z++)
	            {
	                Console.Write($"{array[i, j, z]} [{i},{j},{z}] ");
	            }
	        }
	        Console.WriteLine();
	    }
	    Console.WriteLine();
	}
	

	int[,,] array = new int[5, 3, 3];
	FillArray(array);
	PrintArray(array);
    */


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write($"{array[i, j, z]} [{i},{j},{z}] ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] array1 = new int[4, 4, 4];
int rand = 10;

for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        for (int z = 0; z < array1.GetLength(2); z++)
        {
            array1[i, j, z] = rand;
            rand++;
        }

    }
}


int[,,] array2 = new int[3, 3, 3];

for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        for (int z = 0; z < array2.GetLength(2); z++)
        {
            int x = new Random().Next(0, 3);
            int y = new Random().Next(0, 3);
            int z1 = new Random().Next(0, 3);

            while (array1[x, y, z1] == 0)
            {
                x = new Random().Next(0, 3);
                y = new Random().Next(0, 3);
                z1 = new Random().Next(0, 3);
            }
            array2[i, j, z] = array1[x, y, z1];
            array1[x, y, z1] = 0;
        }

    }
}

PrintArray(array2);

