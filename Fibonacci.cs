using System;
class Fibonacci
{
	public static void Main(String[] args)
	{
		int fiboNumber1 = 0, fiboNumber2 = 1;
		int fiboNumber3;
		Console.WriteLine("Enter a Number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		
		Console.Write(fiboNumber1 + " " + fiboNumber2 + " ");
		
		for(int i = 2; i <number; i++)
		{
			fiboNumber3 = fiboNumber1 + fiboNumber2;
			fiboNumber1=fiboNumber2;
			fiboNumber2=fiboNumber3;
			
			Console.Write(fiboNumber3 + " ");
		}
	}
	
}