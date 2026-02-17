using System;

namespace SumOfNumbers
{
	class Program
	{
		static void Main()
		{
			int num, sum = 0, digit;

			Console.WriteLine("Enter a number: ");
			num = int.Parse(Console.ReadLine());

			while (num > 0)
			{
				digit = num % 10;
				sum = sum + digit;
				num = num / 10;
			}
			Console.WriteLine("Sum of digits = " + sum);
		}
	}
}