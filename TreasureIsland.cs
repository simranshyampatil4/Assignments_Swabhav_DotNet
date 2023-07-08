using System;

class TreasureIsland
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Welcome to Treasure Island...");
		Console.WriteLine("Your Mission is to find the Treasure");
		
		while(true)
		{
			Console.WriteLine("You are at a crossroad. Where do you want to go? (Type 'left' or 'right')");
			string input = Console.ReadLine();

			if(input.Equals("left", StringComparison.OrdinalIgnoreCase))
			{
				Console.WriteLine("You have reached a lake. What do you want to do? (Type 'swim' or 'wait')");
				input = Console.ReadLine();

				if(input.Equals("wait", StringComparison.OrdinalIgnoreCase))
				{
					Console.WriteLine("A boat arrives and you cross the lake safely");
					Console.WriteLine("Now you encounter a door. What colour is the door? (Type 'red' or 'blue' or 'yellow') ");
					input = Console.ReadLine();

					if(input.Equals("red", StringComparison.OrdinalIgnoreCase))
					{
						Console.WriteLine("Burned By Fire...");
						Console.WriteLine("Game Over!...");
						break;
					}
					else if(input.Equals("blue", StringComparison.OrdinalIgnoreCase))
					{
						Console.WriteLine("Eaten By Beast...");
						Console.WriteLine("Game Over!...");
						break;
					}
					else if(input.Equals("yellow", StringComparison.OrdinalIgnoreCase))
					{
						Console.WriteLine("Congratulations you found the treasure..");
						Console.WriteLine("You win!...");
						break;
					}
					else
					{
						Console.WriteLine("Invalid input. Game Over!...");
						break;
					}

				}
				else if(input.Equals("swim", StringComparison.OrdinalIgnoreCase))
				{
					Console.WriteLine("Attack by trout..");
					Console.WriteLine("Game Over!...");
					break;
				}
				else
				{
					Console.WriteLine("Invalid input. Game Over!...");
					break;
				}
				
			}
			
			else if(input.Equals("right", StringComparison.OrdinalIgnoreCase))
			{
				Console.WriteLine("Fall into a hole");
				Console.WriteLine("Game Over!...");
				break;
			}
			else
			{
				Console.WriteLine("Invalid input. Game Over!...");
				break;
				
			}

		}
	}
}
