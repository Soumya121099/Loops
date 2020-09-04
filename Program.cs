using System;

namespace Loops
{
	class Program
	{
		static void Main(string[] args)
		{
			int counter = 0;
			while (counter < 10)
			{
				Console.WriteLine($"Hello World! The counter is {counter}");
				counter++;
			}
		}
	}
}
