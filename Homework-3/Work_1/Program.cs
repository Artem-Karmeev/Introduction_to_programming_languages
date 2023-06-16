/*Задача 19: Напишите программу, 
 которая принимает на вход пятизначное число и проверяет, 
 является ли оно палиндромом.*/


void CheckPalindrome(string x)
{
    string a = x;
    string str = a.ToString();

if (str[0] == str[4] && str[1] == str[3])
{
    Console.WriteLine($"Число {a} является палиндромом ");
}
else 
{
    Console.WriteLine($"Число {a} не является палиндромом ");
}
}

Console.WriteLine("Введите пятизначное число для проверки: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 9999 && a < 100000)
{
    string b = Convert.ToString(a);
    CheckPalindrome(b);
}
else
{
    Console.WriteLine($"Число {a} не является пятизначным, попробуйте еще раз. ");
}
