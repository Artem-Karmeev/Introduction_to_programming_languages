/*Задача 27: Напишите программу,
которая принимает на вход число и выдаёт сумму цифр в числе.
Для решения задания использование цикла for является обязательным условием

452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string strNum = num.ToString();
int[]array = new int[strNum.Length];
int sum = 0;

for (int i = 0; i < strNum.Length; i++)
{
    array[i] = int.Parse(strNum[i].ToString());
    sum = sum + array[i];
}
Console.WriteLine(sum);