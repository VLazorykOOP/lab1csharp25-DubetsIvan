using System;

class Program_5
{
	static double dilennia(double a, double b)
	{
		return a / b;
	}
	static void Main5(string[] args)
	{	
		Console.WriteLine("����i�� �: ");
		double a = double.Parse(Console.ReadLine());
		Console.WriteLine("����i�� b: ");
		double b = double.Parse(Console.ReadLine());
		Console.WriteLine("��������� (a/b): " + dilennia(a, b));
	}
}