using System;
public class MiddleThreeElements{
	public static void Main(){
		int[] arr = {1,5,7,9,11,13};
		PrintArray(Mid(arr));		
	}
	private static int[] Mid(int[] arr){
		int[] result = new int[3];
		
		for(int i=0; i<3; i++){
			result[i]=arr[arr.Length/2-1+i];
		}
		
		return result;
	}
	private static void PrintArray(int[] arr){
		Console.Write("Array: ");
		foreach(int i in arr)Console.Write(i+" ");
		Console.WriteLine();
	}
}
