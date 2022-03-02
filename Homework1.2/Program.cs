// Задача 2: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число А ->  ");
string inputA = Console.ReadLine();
int A = int.Parse(inputA);

Console.WriteLine("Введите число B ->  ");
string inputB = Console.ReadLine();
int B = int.Parse(inputB);

Console.WriteLine("Введите число C ->  ");
string inputC = Console.ReadLine();
int C = int.Parse(inputC);

int max = A;

if (B> max);
    max= B;
if (C> max)   
    max= C;
if (A> max) 
    max= A;
Console.WriteLine($"Максимальное число- {max}");

