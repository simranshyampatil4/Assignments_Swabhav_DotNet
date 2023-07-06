using System;
class Prime
{
	public static void Main(String[] args)
	{
		int number;
		bool isPrime = true;
		
		Console.WriteLine("Enter a Number: ");
		number = Convert.ToInt32(Console.ReadLine());
		
		if(number < 2)
		{
			isPrime = false;
		}
		else
		{
			for(int i = 2; i <= number/2; i++)
			{
				if(number % i == 0)
				{
					isPrime = false;
					break;
				}
			}
		}
		
		string result = isPrime ? "Prime No." : "Not a Prime No.";
		Console.WriteLine("The given number " + number + " is a " + result);
	}
}