using System;

namespace CompoundInterest
{
     class Program
    {
        static void Main(string[] args)
        {
			double p = double.Parse(Console.ReadLine());
			double r = double.Parse(Console.ReadLine());
			double n = double.Parse(Console.ReadLine());
			double ci= p* Math.Pow((1 + r / 100), n) - p;
			Console.WriteLine("Principal amount is : " + (p));
			Console.WriteLine("Rate of interest is : " + (r));
			Console.WriteLine("Number of years is : " + (n));
			Console.WriteLine("Compound Interest is : " + (ci));
		}
    }
}
