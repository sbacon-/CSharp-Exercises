using System;
public class ThirteenChecks{
	public static void Main(){
		Console.WriteLine(Check(13));
		Console.WriteLine(Check(14));
		Console.WriteLine(Check(27));
		Console.WriteLine(Check(41));
		
	}
	private static bool Check(int x){
		return x%13==0 || (x-1)%13==0;
	}
}
