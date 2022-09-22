using System;

namespace ProjectTest
{
	class MainClass
	{
		public static void Main (string[] args)//Функция Main
		{
			int user_number = 23;
			Console.WriteLine("Hello world!");

			user_number = Convert.ToInt32(Console.ReadKey());
			Console.WriteLine("Your number is: " + user_number);
			Console.ReadKey();
		}
	}
}