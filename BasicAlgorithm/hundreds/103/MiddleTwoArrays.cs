using System;
public class MiddleTwoArrays{
	public static void Main(){
		int[] arr = {1,5,7,9,11,13};
		PrintArray(arr);
		PrintArray(Convert(arr));	
	}
	private static int[] Convert(int[] arr){
		int[] result = new int[2];
		result[0]=arr[arr.Length/2-1];	
		result[1]=arr[arr.Length/2];	
		return result;
	}
	private static void PrintArray(int[] arr){
		Console.Write("Array: ");
		foreach(int a in arr)Console.Write(a+" ");
		Console.WriteLine();
	}
}
