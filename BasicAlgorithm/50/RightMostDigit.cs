using System;
public class RightMostDigit{
	public static void Main(){
		Console.WriteLine(Check(11,21,31));
		Console.WriteLine(Check(11,22,31));
		Console.WriteLine(Check(11,22,33));	
	}
	private static bool Check(int x, int y, int z){
		x%=10;
		y%=10;
		z%=10;

		return x==y || x==z || y==z;
	}
}
