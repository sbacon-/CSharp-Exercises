using System;
public class MiddleElementsArray{
	public static void Main(){	

		int[] ar1 = {10,20,-30,-40,30};
		int[] ar2 = {10,20,30,40,30};

		PrintArray(Mid(ar1,ar2));	
	}
	private static int[] Mid(int[] ar1, int[] ar2){
		int[] arr = new int[2];
		arr[0] = ar1[ar1.Length/2];
		arr[1] = ar2[ar2.Length/2];
		return arr;
	}
	private static void PrintArray(int[] arr){
		Console.Write("New array: ");
		foreach(int a in arr)Console.Write(a+" ");
		Console.WriteLine();
	}
}
