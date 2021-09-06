using System;
public class TenFirstOrLast{
	public static void Main(){
		int[] arr = {10,20,40,50};	
		int[] arr2= {5,20,40,10};	
		int[] arr3= {10,20,40,10};	
		int[] arr4= {12,24,35,55};	
		Console.WriteLine(Check(arr));
		Console.WriteLine(Check(arr2));
		Console.WriteLine(Check(arr3));
		Console.WriteLine(Check(arr4));
	}
	private static bool Check(int[] arr){
		return arr[0]==10 || arr[arr.Length-1]==10;
	}
}
