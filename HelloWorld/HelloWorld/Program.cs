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

		// Updated upstream
			Abality abality = new Abality();
			abality.Language();

			
		//Stashed changes
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
// Updated upstream
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
	
	class Finance
	{
		public static void Calculate()
		{
			double income = 156000;
			double tax = income * 0.05;
			double incomeAfterTax = income - tax;
			double healthInsurance = income * 0.22;
			double pension = income * 
			double 
			double socialInsurance = 

		}
		// Stashed changes
	}
}