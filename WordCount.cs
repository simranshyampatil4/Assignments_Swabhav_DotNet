using System;
class WordCount
{
	public static void Main(String[] args)
	{
		string sentence;
		Console.WriteLine("Enter a Sentence: ");
		sentence = Console.ReadLine();
		
		int count = 1;
		int len = 0;
		
		while(len<=sentence.Length-1)
		{
			if(sentence[len]==' ' || sentence[len]=='\n' || sentence[len]=='\t' )
			{
				count++;
			}
			
			len++;
		}
		
		Console.Write("The total count of words in the given sentence is " + count);
	}
}