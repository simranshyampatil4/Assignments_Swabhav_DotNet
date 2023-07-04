using System;
class PrintReverse
{
	public static void Main(String[] args)
	{
		int number,remainder;
		int reverse = 0;
		
		Console.WriteLine("Enter a Number: ");
		number = Convert.ToInt32(Console.ReadLine());
		
		while(number!=0)
		{
			remainder = number%10;
			reverse = reverse * 10 + remainder;
			number = number/10;
		}
		
		Console.WriteLine("Reversed Number is : " + reverse);
	}
	
	
}