using System;
public class SurroundingFives{
	public static void Main(){
		int[] ar1 = { 3, 5, 5, 3, 7 };
		int[] ar2 = { 3, 5, 5, 4, 1, 5, 7};
		int[] ar3 = { 3, 5, 5, 5, 5, 5};
		int[] ar4 = { 2, 4, 5, 5, 6, 7, 5};
		Console.WriteLine(Check(ar1));
		Console.WriteLine(Check(ar2));
		Console.WriteLine(Check(ar3));
		Console.WriteLine(Check(ar4));
		
	}
	private static bool Check(int[] arr){
		for(int i = 0; i<arr.Length; i++){
			if(arr[i]==5){
				if(i==0 && !(arr[i+1]==5))return false;
				else if(i==arr.Length-1 && !(arr[i-1]==5))return false;
				else if(!(arr[i-1]==5 || arr[i+1]==5))return false;
			}
		}
		return true;
	}
}
