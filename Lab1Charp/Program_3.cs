using System;

class Program_3
{
	static void Main3(string[] args)
	{
		Console.WriteLine("������ �: ");
		double x = double.Parse(Console.ReadLine());	
		Console.WriteLine("������ y: ");
		double y = double.Parse(Console.ReadLine());
		if (x * x + y * y < 625 && y < -Math.Abs(x))
			Console.WriteLine("���");
		else if (x * x + y * y > 625 && y > -Math.Abs(x))
			Console.WriteLine("Hi");
		else Console.WriteLine("�� ���i");
	}
}