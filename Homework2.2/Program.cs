//Задача 2: Напишите программу, которая выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число ->");
string inputN = Console.ReadLine();
int N =int.Parse(inputN);
Console.WriteLine($"Вторая цифра числа {N/100%10}");
