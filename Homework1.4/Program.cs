// Задача 4: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write ("Введите число ");
string  numberN= Console.ReadLine();
int N = int.Parse(numberN);

int count=1;
while (count <= N)
{
if (count%2==0)
    Console.WriteLine($"{count} - четное");
count =count +1;     
}



