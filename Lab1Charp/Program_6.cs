using System;

class Program_6
{
	static double Sum(double a, double b)
	{
		double sum = (a / (a * a + 1)) +(b / (b * b + 1));
		return sum;
	}

	static void Main(string[] args)
	{
		Console.WriteLine("����i�� �:");
		double a = double.Parse(Console.ReadLine());	
		Console.WriteLine("����i�� b:");
		double b = double.Parse(Console.ReadLine());
		Console.WriteLine("���������: " + Sum(a, b));
	}
}