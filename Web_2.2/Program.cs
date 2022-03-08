// 2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа. Например,78 -> 8 , 12-> 2, 85 -> 8

Random rnd = new Random();

int value = rnd.Next(10,99);
while (value != 98)
{
    Console.WriteLine($"Случайное значение= {value}");
    value = rnd.Next(10,99);
}
int Randomint (int min, int max)
{
    Random rnd = new Random();
    int value =rnd.Next(min,max);
    return value;
}