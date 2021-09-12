using System;
public class SpecificRepetitions{
	public static void Main(){
		int[] ar1 = {3,7,5,5,3,7};	
		int[] ar2 = {3,7,5,5,3,7,5};	
		
		Console.WriteLine(Check(ar1,2));
		Console.WriteLine(Check(ar1,3));
		Console.WriteLine(Check(ar2,3));
	}
	private static bool Check(int[] arr, int rep){
		int len = arr.Length;

		for(int i = 0; i<rep; i++){
			if(arr[i] != arr[len-rep+i])return false;
		}

		return true;
	}
}
