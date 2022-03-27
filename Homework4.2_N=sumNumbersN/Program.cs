// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int a, b;
Console.WriteLine("Введите число =>");
a = int.Parse(Console.ReadLine());

int sum =0;
while( a>0)
{
    b=a%10;
    a=a/10;
    sum= sum+b;
}
Console.WriteLine("Сумма цифр в числе: "+ sum);

