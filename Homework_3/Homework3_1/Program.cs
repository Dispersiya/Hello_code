// Задача 1: Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.


Console.WriteLine("Введите число");
string n = Console.ReadLine();
int len= n.Length;
if ((n[0]== n[4]) && (n[1]== n[3])) Console.WriteLine("palindrom");
else Console.WriteLine("no palindrom");