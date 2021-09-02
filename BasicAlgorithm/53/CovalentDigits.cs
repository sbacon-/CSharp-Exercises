using System;
public class CovalentDigits{
	public static void Main(){
		Console.WriteLine(Check(11,21));
		Console.WriteLine(Check(11,20));
		Console.WriteLine(Check(10,10));
		
		Console.WriteLine(Check(11,22,33));
		Console.WriteLine(Check(11,22,31));		
	}
	private static bool Check(int x, int y, int z){
		return Check(x,y) || Check(x,z) || Check(y,z);
	}
	private static bool Check(int x, int y){
		int x1=x/10, x2=x%10, y1=y/10, y2=y%10;

		return x1==y1 || x1 == y2 || x2 == y1 || x2 == y2;
	}
}
