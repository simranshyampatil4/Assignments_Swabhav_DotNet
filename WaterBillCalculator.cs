using System;

class WaterBillCalculator
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Water Bill Calculator..");

		Console.Write("Enter No. of units consumed: ");
		int unitsConsumed = Convert.ToInt32(Console.ReadLine());

		const int meterCharge = 75;
		int charge;
		
		if(unitsConsumed <= 100)
		{
			charge = unitsConsumed * 5;
		}
		else
		{
			if(unitsConsumed <= 250)
			{
				charge = unitsConsumed * 10;
			}
			else
			{
				charge = unitsConsumed * 20;
			}
		}

		int totalWaterBill = charge + meterCharge;

		Console.Write("Total Water Bill: " + totalWaterBill);
		Console.ReadLine();
	}
}