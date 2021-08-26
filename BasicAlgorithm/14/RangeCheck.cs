using System;
public class RangeCheck{
	public static void Main(){

		Console.WriteLine(Check(100,199));
		Console.WriteLine(Check(250,300));
		Console.WriteLine(Check(105,190));
		
	}
	private static bool Check(int x, int y){
		bool a = x>=100 && x<=200;
		bool b = y>=100 && y<=200;
		return a || b;
	}
}
