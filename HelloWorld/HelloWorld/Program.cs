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

			Property sing = new Property();
			sing.Sing();
			//Pause system execution
			Console.ReadLine();
		}
	}

	class Property
	{

		public void Sing()
		{
		Console.WriteLine("What doesn't kill you makes you stronger");
		}
	} 
}
