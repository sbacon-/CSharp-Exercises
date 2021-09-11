using System;
public class DoubleFiveCheck{
	public static void Main(){
		int[] ar1 = {1,5,6,9,10,17};
		int[] ar2 = {1,5,5,9,10,17};
		int[] ar3 = {1,5,5,9,10,17,5,5};
		Console.WriteLine(Check(ar1));
		Console.WriteLine(Check(ar2));
		Console.WriteLine(Check(ar3));
	}
	private static bool Check(int[] arr){
		for(int i = 0; i < arr.Length-1; i++)if(arr[i]==5&&arr[i+1]==5)return true;
		return false;
	}
}
