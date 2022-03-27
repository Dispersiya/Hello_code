// Напишите программу, которая задаёт массив из 8 элементов 
//случайными числами и выводит их на экран.
int[] Array = new int[8];
Random rnd = new Random(); 
for (int i=0; i<8; i++)
{
Array[i] = rnd.Next(1,999);
Console.Write($"{Array[i]} ");
}
Console.WriteLine();
