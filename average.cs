/* 
 calculates the average of a set of marks, until the user types
 “end”.
 (C) Zeus pass Development environments.
 */
using System;

public class Average
{
	public static void Main()
	{
		float sumatoryMarks=0, stringConverted=0 , count=0 , avarageMarks=0;
		string conditionFinish;
		
		Console.Write("Insert a mark: ");
		conditionFinish=Console.ReadLine();	
			 
		while(conditionFinish!="end")
		{  
			stringConverted=Convert.ToSingle(conditionFinish);
			
			count++; 
			
			sumatoryMarks+=stringConverted; 
			 
			Console.Write("Insert a mark or type end for finish: ");
			conditionFinish=Console.ReadLine();
		}
		if(count!=0)
		{
			avarageMarks=sumatoryMarks/count;  		
			Console.WriteLine("The average is {0}.",avarageMarks);
		}
	}
}