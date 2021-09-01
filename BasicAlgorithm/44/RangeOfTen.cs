using System;
public class RangeOfTen{
	public static void Main(){
		Console.WriteLine(Check(3));	
		Console.WriteLine(Check(7));	
		Console.WriteLine(Check(8));	
		Console.WriteLine(Check(21));	
	}
	private static bool Check(int x){
		return x%10 >= 8 || x%10<=2;
	}
}
