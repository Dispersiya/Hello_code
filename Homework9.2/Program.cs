﻿// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Promt(string msg)
{
    Console.Write(msg);
    string strValue= Console.ReadLine();
    int Value =int.Parse(strValue);
    return Value;
}
int M = Promt("Введите число M  ");
int N = Promt("Введите число N  ");

int result = 0;
if (M <N)
 for (int i = M; i <= N;  i++)
	result += i;
Console.WriteLine(result);
