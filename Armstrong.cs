using System;
class Armstrong
{
	public static void Main(String[] args)
	{
		int number, remainder,temp;
		int sum = 0;
		
		Console.WriteLine("Enter a Number: ");
		number = Convert.ToInt32(Console.ReadLine());
		
		temp = number;
		
		while(temp!=0)
		{
			remainder = temp%10;
			temp = temp/ 10;
			sum = sum + (remainder * remainder * remainder);
			
		}
		
		if(number == sum)
		{
			Console.WriteLine("The given Number " + number + " is an Armstrong number.");
		}
		else
		{
			Console.WriteLine("The given Number " + number + " is not an Armstrong number.");
		}
	}
}