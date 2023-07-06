using System;
class PrimeRange
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Prime No between 1 to 100:");
		
		for(int i = 1; i<=100; i++)
		{
			if(checkPrime(i))
			{
				Console.Write(i + " ");
			}
		}
	}
	
	public static bool checkPrime(int number)
	{
		if(number < 2)
		{
			return false;
		}
		else
		{
			for(int i = 2; i <= number/2; i++)
			{
				if(number % i == 0)
				{
					return false;
				}
			}
		}
		
		return true;
	}
}