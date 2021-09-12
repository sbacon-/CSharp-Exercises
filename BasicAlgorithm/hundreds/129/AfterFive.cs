using System;
public class AfterFive{
	public static void Main(){
		int[] ar1 = {1,2,3,5,7,9,11};	
		PrintArray(Conv(ar1));
	}
	private static int[] Conv(int[] arr){
		int index = Array.IndexOf(arr,5);
		int[] res = new int[arr.Length-index-1];
		for(int i = 0; i<res.Length; i++){
			res[i]=arr[index+i+1];
		}
		return res;
	}
	private static void PrintArray(int[] arr){
		Console.Write("new array: ");
		foreach(int a in arr)Console.Write(a+" ");
		Console.WriteLine();
	}
}
