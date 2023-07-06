using System;
class SpaceCount
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Enter a Sentence: ");
		string sentence = Console.ReadLine();
		
		int count = 0;
		
		for(int i = 0; i < sentence.Length; i++)
		{
			if(sentence[i] == ' ')
			{
				count++;
			}
		}
		
		Console.Write("The total count of spaces in the given sentence is " + count);
	}
}