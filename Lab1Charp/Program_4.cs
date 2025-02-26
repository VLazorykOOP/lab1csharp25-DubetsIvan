using System;

class Program_4
{
	static void Main4(string[] args)
	{
		int i;
		string[] month = { "Сiчень", "Лютий", "Березень", "Квiтень", "Травень", "Червень", "Липень", "Серпень", "Вересень", "Жовтень", "Листопад", "Грудень" };
		Console.WriteLine("Введiть m: ");
		int m = int.Parse(Console.ReadLine());
		if (m >= 12) {
			i = (m - 1) % 12;
		}
		else
		{
			i = 12 - m + 1;
		}
		Console.WriteLine("Мiсяць: " + month[i]);
	}
}