/*
 * A program printing out your name.
 */
using System;
using System.Text;

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

			Abality abality = new Abality();
			abality.Language();
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

	class Abality
	{
		public void Language()
		{
			string first = "Burmese";
			string second = "English";
			string third = "Japanese";
			StringBuilder stringBuilder = new StringBuilder($"I can speak three languages. These are {first} {second} {third}");
			Console.WriteLine(stringBuilder);
		}

	}
}