﻿// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе
//показывает последнюю цифру этого числа.
// Например: 456 -> 6,782 -> 2 , 918 -> 8
Console.WriteLine("Введите трёхзначное число ->");
string inputN = Console.ReadLine();
int N =int.Parse(inputN);
Console.WriteLine($"Вторая цифра числа {N/10%10}");
