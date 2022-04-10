// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
double[,] a = new double[5, 10];
Random random = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 10; j++)
    {
        a[i, j] = random.NextDouble() * 100; 
        Console.Write("{0,6:F2}", a[i, j]);
    }
    Console.WriteLine();
}
