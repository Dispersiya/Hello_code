//Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.

Console.WriteLine("Введите число -> ");
string inputNuber = Console.ReadLine();
int number = int.Parse(inputNuber);

if (number == 1) Console.WriteLine("Понедельник, рабочий день"); else
if (number == 2) Console.WriteLine("Вторник, рабочий день"); else
if (number == 3) Console.WriteLine("Среда, рабочий день"); else
if (number == 4) Console.WriteLine("Четверг, рабочий день"); else
if (number == 5) Console.WriteLine("Пятница, рабочий день"); else
if (number == 6) Console.WriteLine("Суббота, выходной день"); else
if (number == 7) Console.WriteLine("Воскресенье, выходной день"); else
{
    Console.WriteLine("В неделе 7 дней, введите цифру от 1 до 7");
}