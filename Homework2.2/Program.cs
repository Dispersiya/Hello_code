//Задача 2: Напишите программу, которая выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа.


Random rnd = new Random();
int value = rnd.Next(100,999);
int number = value/100*10+(value%10);
Console.WriteLine(value);
Console.WriteLine(number);