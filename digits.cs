/* 
 calculates how many numbers of 1, 2, 3 or more digits are
 entered by the user until he/she types “end”.
 */
using System;

class digits
{
	static void Main()
	{
		int one_digit = 0, two_digit= 0, three_digit= 0, more_that4 = 0,converted_string;
		string condition_finish;
		
		Console.Write("insert numbers and when you want to finish type final: ");
		condition_finish = Console.ReadLine();
		
		while (condition_finish!="end")
		{
			converted_string = Convert.ToInt32(condition_finish);
			
			if (converted_string != 0)
			{
				if(converted_string/10 == 0)
				{
					one_digit ++; 
				} 
				else 
				{
					if (converted_string/100 == 0)
					{
						two_digit ++; 
					}
					else
					{
						if (converted_string/1000 == 0)
						{
							three_digit ++; 
						} 
						else
						{
						more_that4++;  
						}
					}
				}									
			}
			
		condition_finish = Console.ReadLine();
		
		}
		
		Console.WriteLine("one: {0} two: {1} three: {2} more: {3}",
			one_digit,	two_digit, three_digit, more_that4); 
	}
}