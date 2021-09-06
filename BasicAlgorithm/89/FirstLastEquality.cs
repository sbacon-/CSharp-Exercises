using System;
public class FirstLastEquality{
	public static void Main(){
		
		int[] arr = {10,20,40,50};
		int[] ar2 = {10,20,40,10};
		int[] ar3 = {12,25,45,66};
		Console.WriteLine(Check(arr));
		Console.WriteLine(Check(ar2));
		Console.WriteLine(Check(ar3));
	}
	private static bool Check(int[] arr){
		return arr[0]==arr[arr.Length-1];
	}
}
