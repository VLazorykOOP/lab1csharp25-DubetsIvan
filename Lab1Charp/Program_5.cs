using System;

class Program_5
{
	static double dilennia(double a, double b)
	{
		return a / b;
	}
	static void Main5(string[] args)
	{	
		Console.WriteLine("¬ведiть а: ");
		double a = double.Parse(Console.ReadLine());
		Console.WriteLine("¬ведiть b: ");
		double b = double.Parse(Console.ReadLine());
		Console.WriteLine("–езультат (a/b): " + dilennia(a, b));
	}
}