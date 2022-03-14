// Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.WriteLine(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

int N = Prompt("Введите число =>");

int A = 1;
Console.Write( A + " ");
while (A < N)
{
    A= A+1;
    Console.WriteLine(A*A*A + " ");
}

