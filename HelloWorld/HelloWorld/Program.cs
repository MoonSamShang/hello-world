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
			Console.ReadLine();
		}
	}
}
