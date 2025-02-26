using System;

class Program_3
{
	static void Main3(string[] args)
	{
		Console.WriteLine("Введіть х: ");
		double x = double.Parse(Console.ReadLine());	
		Console.WriteLine("Введіть y: ");
		double y = double.Parse(Console.ReadLine());
		if (x * x + y * y < 625 && y < -Math.Abs(x))
			Console.WriteLine("Так");
		else if (x * x + y * y > 625 && y > -Math.Abs(x))
			Console.WriteLine("Hi");
		else Console.WriteLine("На межi");
	}
}