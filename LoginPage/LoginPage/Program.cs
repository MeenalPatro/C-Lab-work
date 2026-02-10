using System;

namespace login
{
	class LoginApp
	{
		static void Main()
		{
			string correctusername = "Meenal";
			string correctpassword = "0327";

			int attempts = 3;

			while (attempts > 0)
			{
				Console.Write("Enter Username: ");
				string username = Console.ReadLine();

				Console.Write("Enter Password: ");
				string password = Console.ReadLine();

				if (username == correctusername && password == correctpassword)
				{
					Console.WriteLine("\nLogin Successful!");
					break;
				}
				else
				{
					attempts--;
					Console.WriteLine("\nInvalid credentials!");

					if (attempts > 0)
					{
						Console.WriteLine("Remaining attempts: " + attempts + "\n");
					}
					else
					{
						Console.WriteLine("Account locked. Too many failed attempts.");
					}
				}
			}

			Console.ReadLine(); 
		}
	}
}