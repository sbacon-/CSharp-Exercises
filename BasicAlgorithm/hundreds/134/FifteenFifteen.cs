using System;
public class FifteenFifteen{
	public static void Main(){
		int[] ar1 = { 5, 5, 1, 15, 15 };
		int[] ar2 = { 15, 2, 3, 4, 15 };
		int[] ar3 = { 3, 3, 15, 15, 5, 5};
		int[] ar4 = { 1, 5, 15, 7, 8, 15};
		Console.WriteLine(Check(ar1));
		Console.WriteLine(Check(ar2));
		Console.WriteLine(Check(ar3));
		Console.WriteLine(Check(ar4));
	}
	private static bool Check(int[] arr){
		for(int i = 0; i<arr.Length-1; i++){
			if(arr[i] == 15 && arr[i]==arr[i+1])return true;
		}
		return false;
	}
}
