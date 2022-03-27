// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
Console.Write("Введите координату Х первой точки =>");
string inputX1 = Console.ReadLine();
int X1= int.Parse(inputX1);
Console.Write("Введите координату Y первой точки =>");
string inputY1 = Console.ReadLine();
int Y1= int.Parse(inputY1);
Console.Write("Введите координату Z первой точки =>");
string inputZ1 = Console.ReadLine();
int Z1= int.Parse(inputZ1);
Console.Write("Введите координату Х второй точки =>");
string inputX2 = Console.ReadLine();
int X2= int.Parse(inputX2);
Console.Write("Введите координату Y второй точки =>");
string inputY2 = Console.ReadLine();
int Y2= int.Parse(inputY2);
Console.Write("Введите координату Z второй точки =>");
string inputZ2 = Console.ReadLine();
int Z2= int.Parse(inputZ2);
double answer = Math.Sqrt((X2-X1)*(X2-X1) + (Y2-Y1)*(Y2-Y1) + (Z2 - Z1)*(Z2 - Z1));
Console.WriteLine(answer);