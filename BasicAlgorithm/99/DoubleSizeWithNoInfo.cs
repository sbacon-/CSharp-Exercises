using System;
public class DoubleSizeWithNoInfo{
	public static void Main(){
		int[] arr = {10,20,-30,-40,30};
		PrintArray(DeOptimize(arr));	
	}
	private static int[] DeOptimize(int[] arr){
		int[] res = new int[arr.Length*2];
		res[0]=arr[0];

		return res;
	}
	private static void PrintArray(int[] arr){
		Console.Write("New Array: ");
		foreach(int i in arr)Console.Write(i+" ");
		Console.WriteLine();
	}
}
