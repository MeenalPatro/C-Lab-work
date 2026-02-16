using System;

namespace Factorial
{
	class FactorialProgram
	{
		static void Main()
		{
			int n;
			int fact = 1;

			Console.WriteLine("Enter a number: ");
			n = int.Parse(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				fact = fact * i;
			}

			Console.WriteLine("Factorial of is: " + fact);
		}
	}
}