using System;

namespace Decision_Making_Lab_Tuesday
{
	class Program
	{
		static void Main(string[] args)
		{
			//user input
			//Asking the user for a number and determining whether even or odd
			//and corresponding the output based on the number given
			Console.WriteLine("Hello, what is your name?");
			string name = Console.ReadLine();
			string answer = string.Empty;
			
			do
			{
				//running a while loop to allow the user to pick multiple numbers or stop		

				Console.WriteLine($"Ok, {name} please enter a positive integer between 1 and 100.");
				int number = int.Parse(Console.ReadLine());
				// processing and output together
				// determining whether the number is even or odd and what section 
				// of numbers it falls into.
				if ((number > 100) || (number < 1))
				{
					Console.WriteLine("Please choose a valid number");
				}
				else if ((number % 2 == 0) && (number > 60))
				{
					Console.WriteLine($"Ok {name} your {number} is even");
				}
				else if ((number % 2 == 0) && (number > 26))
				{
					Console.WriteLine("Even");
				}
				else if ((number % 2 == 0) && (number >= 2))
				{
					Console.WriteLine($" Ok, {name} your number is even and less than 25");
				}
				else if (!(number % 2 == 0) && (number > 60))
				{
					Console.WriteLine($" Your number is odd and greater than 60.");
				}
				else
				{
					Console.WriteLine($" Your number is odd and less than 60 {name}");
				}
				Console.WriteLine("Would you like to try another number? y/n");
				answer = Console.ReadLine();
			} while (answer == "y");
			Console.WriteLine($"Thanks for playing the number game {name}");
		}	


	} 
	
}
