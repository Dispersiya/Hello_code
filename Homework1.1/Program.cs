// Задача 1: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число А ->  ");
string inputA = Console.ReadLine();
int A = int.Parse(inputA);

Console.WriteLine("Введите число B ->  ");
string inputB = Console.ReadLine();
int B = int.Parse(inputB);

if (A > B) Console.WriteLine(inputA + ">" + inputB);
else
{
Console.WriteLine(inputB + ">"+ inputA);
}






