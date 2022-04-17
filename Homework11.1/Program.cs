// Определите, является ли число степенью двойки:
class Program
{
    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        if (step(a)) Console.WriteLine("Является степенью двойки");
        else Console.WriteLine("Не являетя степенью двойки");
        Console.ReadKey();
    }
    public static bool step(int a)
    {
        if (a == 2) return true;
        else if (a % 2 == 0) return step(a / 2);
        else return false;
    }
}