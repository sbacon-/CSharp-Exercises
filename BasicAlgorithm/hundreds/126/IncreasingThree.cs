using System;
public class IncreasingThree{
	public static void Main(){
		int[] ar1 = { 1, 2, 3, 5, 3, 7 };
		int[] ar2 = { 3, 7, 5, 5, 3, 7 };
		int[] ar3 = { 3, 7, 5, 5, 6, 7, 5 };
		Console.WriteLine(Check(ar1));
		Console.WriteLine(Check(ar2));
		Console.WriteLine(Check(ar3));
	
	}
	private static bool Check(int[] arr){
		for(int i = 0; i<arr.Length -2 ; i++){
			if(arr[i]<arr[i+1] && arr[i+1]<arr[i+2])return true;
		}
		return false;
	}
}
