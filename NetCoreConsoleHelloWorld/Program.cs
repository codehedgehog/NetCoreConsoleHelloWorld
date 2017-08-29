
namespace NetCoreConsoleHelloWorld
{
	using System;
	using UtilityLibraries;

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("\nWhat is your name? ");
			var name = Console.ReadLine();
			var date = DateTime.Now;
			Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
			Console.Write("\nPress any key to exit...");
			Console.ReadKey(true);

			int rows = Console.WindowHeight;

			Console.Clear();
			do
			{
				if (Console.CursorTop >= rows || Console.CursorTop == 0)
				{
					Console.Clear();
					Console.WriteLine("\nPress <Enter> only to exit; otherwise, enter a string and press <Enter>:\n");
				}
				string input = Console.ReadLine();
				if (String.IsNullOrEmpty(input)) break;
				Console.WriteLine($"Input: {input} {"Begins with uppercase? ",30}: " +
													$"{(input.StartsWithUpper() ? "Yes" : "No")}\n");
			} while (true);

		}
	}
}
