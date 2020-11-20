/* 
 calculates how many numbers of 1, 2, 3 or more digits are
 entered by the user until he/she types “end”.
 (C) Zeus pass Development environments
 */
using System;

class digits
{
	static void Main()
	{
		int oneDigit = 0, twoDigit= 0, threeDigit= 0, moreThat4 = 0,convertedString;
		string conditionFinish;
		
		Console.Write("insert numbers and when you want to finish type final: ");
		conditionFinish = Console.ReadLine();
		
		while (conditionFinish!="end")
		{
			convertedString = Convert.ToInt32(conditionFinish);
			
			if (convertedString != 0)
			{
				if(convertedString/10 == 0)
				{
					oneDigit ++; 
				} 
				else 
				{
					if (convertedString/100 == 0)
					{
						twoDigit ++; 
					}
					else
					{
						if (convertedString/1000 == 0)
						{
							threeDigit ++; 
						} 
						else
						{
						moreThat4++;  
						}
					}
				}									
			}
			
		conditionFinish = Console.ReadLine();
		
		}
		
		Console.WriteLine("one: {0} two: {1} three: {2} more: {3}",
			oneDigit, twoDigit, threeDigit, moreThat4); 
	}
}