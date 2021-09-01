using System;
public class ThreeXORSeven{
	public static void Main(){
		Console.WriteLine(Check(3));
		Console.WriteLine(Check(7));
		Console.WriteLine(Check(21));
			
	}
	private static bool Check(int x){
		return x%3==0 ^ x%7==0;
	}
}
