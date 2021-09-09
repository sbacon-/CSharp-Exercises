using System;
public class SwapFirstLastElement{
	public static void Main(){
		int[] arr = {1,5,7,9,11,13};
		PrintArray(Switcharoo(arr));		
	}
	private static int[] Switcharoo(int[] arr){
		int temp = arr[0];
		arr[0]=arr[arr.Length-1];
		arr[arr.Length-1]=temp;

		return arr;
	}
	private static void PrintArray(int[] arr){
		Console.Write("Array: ");
		foreach(int i in arr)Console.Write(i+" ");
		Console.WriteLine();
	}
}
