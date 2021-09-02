using System;
public class DifferenceOfTwenty{
	public static void Main(){
		Console.WriteLine(Check(11,21,31));	
		Console.WriteLine(Check(11,22,31));	
		Console.WriteLine(Check(10,20,15));	
	}
	private static bool Check(int x, int y, int z){
		return Math.Abs(x-y)>=20 || Math.Abs(x-z)>=20 || Math.Abs(z-y)>=20;
		
	}
}
