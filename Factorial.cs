using System;
class Factorial
{
	public static void Main(String[] args)
	{	
		int number;
		int fact=1;
		
		Console.WriteLine("Enter a Number: ");
		number= Int32.Parse(Console.ReadLine());
		
		for(int i=1; i<=number; i++)
		{
			fact = fact*i;
		}
		
		Console.WriteLine("Factorial of " + number + " is "  + fact);
	}
}
