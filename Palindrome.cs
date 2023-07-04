using System;
class Palindrome
{
	public static void Main(String[] args)
	{
		int number, remainder, temp;
		int reverse = 0;
		
		Console.WriteLine("Enter a Number: ");
		number = Convert.ToInt32(Console.ReadLine());
		
		temp = number;
		
		while(temp!=0)
		{
			remainder = temp%10;
			reverse = reverse * 10 + remainder;
			temp = temp / 10;
			
		}
		
		if(number==reverse)
		{
			Console.WriteLine("The given number " + number + " is a Palindrome");
		}
		else
		{
			Console.WriteLine("The given number " + number + " is not a Palindrome");
		}
	}
}