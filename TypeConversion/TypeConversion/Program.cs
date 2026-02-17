//WAP to create two variables with int and float datatype and perform automatically conversion and forced conversion.
using System;

namespace TypeConversion
{
	class Program
	{
		static void Main(string[] args)
		{
			float a;
			int b = 27;
			a = b;
			Console.WriteLine(a);

			float x = 2000.0F;
			int y;
			y = (int)x;
			Console.WriteLine(y);
		}
	}
}