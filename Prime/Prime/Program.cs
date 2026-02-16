using System;

namespace Prime
{
	class Program
	{
		static void Main()
		{
			bool isPrime = true;

			Console.WriteLine("Enter a number: ");
			int n = int.Parse(Console.ReadLine());

			if (n <= 1)
			{
				isPrime = false;
			}
			else
			{
				for (int i = 2; i <= n / 2; i++)
				{
					if (n % i == 0)
					{
						isPrime = false;
						break;
					}
				}
			}

			if (isPrime)
				Console.WriteLine(n + " is a Prime Number");
			else
				Console.WriteLine(n + " is not a Prime Number");
		}
	}
}