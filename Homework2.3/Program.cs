//Задача 3: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число ->");
string inputN = Console.ReadLine();
int N =int.Parse(inputN);
if (N/100 == 0) Console.WriteLine("Третьей цифры нет!");
else
{
    while (N >= 1000)
    {
        N= N/10;
    }
    Console.WriteLine($"Третья цифра числа {N%10}");
}