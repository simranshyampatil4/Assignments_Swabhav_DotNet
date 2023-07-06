using System;
class StringPalindrome
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Enter a String: ");
		string string1 = Console.ReadLine();
		
		string string2 = "";
		
		for(int i=string1.Length-1; i>=0; i-- )
		{
			string2 = string2 + string1[i].ToString();
		}
		
		if (string2 == string1) 
        {  
			Console.WriteLine("String is Palindrome");  
        }  
        else  
        {  
            Console.WriteLine("String is not Palindrome");  
        }  
	}
}