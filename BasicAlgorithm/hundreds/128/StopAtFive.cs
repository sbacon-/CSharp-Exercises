using System;
public class StopAtFive{
	public static void Main(){
		int[] ar1 = {1,2,3,5,7};	
		PrintArray(Conv(ar1));
	}
	private static int[] Conv(int[] arr){
		int[] res = new int[Array.IndexOf(arr,5)];
		for(int i = 0; i<res.Length; i++){
			res[i]=arr[i];
		}
		return res;
	}
	private static void PrintArray(int[] arr){
		Console.Write("new array: ");
		foreach(int a in arr)Console.Write(a+" ");
		Console.WriteLine();
	}
}
