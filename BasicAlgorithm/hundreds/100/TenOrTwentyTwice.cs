using System;
public class TenOrTwentyTwice{
	public static void Main(){
		int[] ar1 = {12,20};
		int[] ar2 = {20,20};
		int[] ar3 = {10,10};
		int[] ar4 = {10};
		Console.WriteLine(Check(ar1));	
		Console.WriteLine(Check(ar2));	
		Console.WriteLine(Check(ar3));	
		Console.WriteLine(Check(ar4));	
	}
	private static bool Check(int[] arr){
		if(arr.Length<2)return false;
		if(arr[0]==arr[1] && (arr[0]==10 || arr[0]==20))return true;
		return false;	
	}
}
