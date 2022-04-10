// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N.
int Promt(string msg)
{
    Console.Write(msg);
    string strValue= Console.ReadLine();
    int Value =int.Parse(strValue);
    return Value;
}
int M = Promt("Введите число M  ");
int N = Promt("Введите число N  ");
if (M <N)
 for (int i = M; i <= N;  i++)
 if (i%2==0)
Console.Write(i++ + " ");
