using System;
public class NotFifteenOrTwentyArray{
	public static void Main(){
		int[] arr = {12,20};
		int[] ar1 = {14,15};
		int[] ar2 = {11,21};
		Console.WriteLine(Check(arr));	
		Console.WriteLine(Check(ar1));	
		Console.WriteLine(Check(ar2));	
	}
	private static bool Check(int[] arr){
		foreach(int a in arr){
			if(a==15 || a==20) return false;
		}
		return true;
	}
}
