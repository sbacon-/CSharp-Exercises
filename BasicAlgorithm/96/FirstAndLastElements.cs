using System;
public class FirstAndLastElements{
	public static void Main(){
		int[] arr = {10,20,-30,-40,30};
		PrintArray(FLE(arr));
	}
	private static int[] FLE(int[] arr){
		int[] res = new int[2];

		res[0] = arr[0];
		res[1] = arr[arr.Length-1];

		return res;
	}
	private static void PrintArray(int[] arr){
		Console.Write("New array: ");
		foreach(int i in arr)Console.Write(i+" ");
		Console.WriteLine();
	}
}
