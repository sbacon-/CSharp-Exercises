using System;
public class SumWithSameBase{
	public static void Main(){
		Console.WriteLine(Check(4,5));	
		Console.WriteLine(Check(7,5));	
		Console.WriteLine(Check(10,10));
	}
	private static int Check(int x, int y){
		int sum = x+y;

		return sum.ToString().Length == x.ToString().Length? sum : x;
	}
}
