using System;
public class PriceIsRight{
	public static void Main(){
		Console.WriteLine(Check(4,5));
		Console.WriteLine(Check(7,12));
		Console.WriteLine(Check(10,13));
		Console.WriteLine(Check(17,33));
	}
	private static int Check(int x, int y){
		if(x>13)x=0;
		if(y>13)y=0;
		
		return Math.Max(x,y);//Does not account for negative values; Too Bad
	}
}
