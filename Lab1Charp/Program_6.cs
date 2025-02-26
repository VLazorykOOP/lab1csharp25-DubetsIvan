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
		Console.WriteLine("¬ведiть а:");
		double a = double.Parse(Console.ReadLine());	
		Console.WriteLine("¬ведiть b:");
		double b = double.Parse(Console.ReadLine());
		Console.WriteLine("–езультат: " + Sum(a, b));
	}
}