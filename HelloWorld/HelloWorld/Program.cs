/*
 * A program printing out your name.
 */
using System;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			//Create instance and put the value
			string greeting = "Hello";
			string name = "NMSS";
			//Print out
			Console.WriteLine($"{greeting} my name is {name}.");

			Hobbies hobbies = new Hobbies();
			hobbies.Sing();
			hobbies.Read();
			hobbies.Travel();
			//Pause system execution
			Console.ReadLine();
		}
	}

	class Hobbies
	{

		public void Sing()
		{
		Console.WriteLine("What doesn't kill you makes you stronger");
		}

		public void Read()
		{
			string firstBook = "Gone With The Wind";
			Console.WriteLine($"First ever book that I'd read was {firstBook}.");
		}

		public void Travel()
		{
			string country = "Thailand";
			Console.WriteLine($"I have been to {country}.");
		}
	} 
}