using System;
public class FiveSevenCheck{
	public static void Main(){
		int[] ar1 = {1,5,6,9,10,17};	
		int[] ar2 = {1,4,7,9,10,17};	
		int[] ar3 = {1,1,2,9,10,17};	
		Console.WriteLine(Check(ar1));
		Console.WriteLine(Check(ar2));
		Console.WriteLine(Check(ar3));
	}
	private static bool Check(int[] arr){
		foreach(int a in arr){
			if (a==5 || a==7)return true;
		}
		return false;
	}
}
