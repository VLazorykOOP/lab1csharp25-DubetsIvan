using System;

class Program_2
{
	static void Main2(string[] args)
	{
		Console.WriteLine("����i�� ��������� �����: ");
		string num = Console.ReadLine();
		if (num.Length == 2 && char.IsDigit(num[0]) && char.IsDigit(num[1]))
		{
			Console.WriteLine("����� ��������i");
		}
		else{
			Console.WriteLine("����� �i��i");
		}
	}
}