using System;
public class DifferenceCompare{
	public static void Main(){
		Console.WriteLine(Check(4,5,6));
		Console.WriteLine(Check(7,12,13));
		Console.WriteLine(Check(-1,0,1));
	
	}
	private static bool Check(int s, int m, int l){
		return m-s == l-m;
	}
}
