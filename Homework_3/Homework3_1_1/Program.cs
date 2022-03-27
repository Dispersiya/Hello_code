// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

/*Console.WriteLine("Введите число");
string n = Console.ReadLine();
int len= n.Length;
if ((n[0]== n[4]) && (n[1]== n[3])) Console.WriteLine("palindrom");
else Console.WriteLine("no palindrom");*/
Console.WriteLine("Введите число");
string inputN = Console.ReadLine();
int N = int.Parse(inputN);

int N = (N / 10000 % 10 + N / 10000 % 10 + N / 1000 % 10));
if ((n[0]== n[4]) && (n[1]== n[3])) Console.WriteLine("palindrom");
else Console.WriteLine("no palindrom");