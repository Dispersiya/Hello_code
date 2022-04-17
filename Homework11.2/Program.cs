// Проверка на простое число:
using System;
 
namespace ProstoeChislo
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(IsPrime(num) ? "Простое число" : "Не является простым числом");
 
            Console.ReadLine();
        }
 
        static bool IsPrime(int number)
        {
            if (number == 1)
                return false;
            
            if (number % 2 == 0)
            {
                if (number == 2)
                    return true;
                return false;
            }
            
            int max = (int)Math.Sqrt(number);
            for (int i = 3; i <= max; i += 2)
            {
                if ((number % i) == 0)
                    return false;
            }
            return true;
        }
    }
}