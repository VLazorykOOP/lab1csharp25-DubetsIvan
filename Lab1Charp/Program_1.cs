using System;

class Program_1
{
    static void Main1(string[] args)
    {
        double a, b, c, c_2, sum_p;
        Console.WriteLine("Введiть катет а: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введiть катет b: ");
        b = double.Parse(Console.ReadLine());
        c_2 = a * a + b * b;
        c =Math.Sqrt(c_2);
        sum_p = a + b + c;
        Console.WriteLine("Катет а: " + a);
        Console.WriteLine("Катет b: " + b);
        Console.WriteLine("Гіпотенуза с: " + c);
        Console.WriteLine("Периметр прямокутного трикутника: " + sum_p);
    }
}