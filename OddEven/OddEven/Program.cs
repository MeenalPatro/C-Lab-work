using System;

namespace OddEven
{
     class Program
     {
        static void Main(string[] args)
        {
			int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else 
            {
                Console.WriteLine("Invalid number");
            }

		}
	 }
}
