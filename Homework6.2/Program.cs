// Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
double Promt(string message)
{
    Console.Write(message);
    string strValue= Console.ReadLine();
    double Value =double.Parse(strValue);
    return Value;
}

Console.Write("Задайте значение b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Задайте значение k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Задайте значение b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Задайте значение k2: ");
double k2 = double.Parse(Console.ReadLine());
double x =(b2-b1)/(k2-k1);
double y= k2*x + b2;
Console.WriteLine($"x: {x}, y; {y}");
