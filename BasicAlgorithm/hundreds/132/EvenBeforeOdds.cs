using System;
public class EvenBeforeOdds{
	public static void Main(){
		int[] arr = { 1, 2, 5, 3, 5, 4, 6, 9, 11 };	
		PrintArray(Conv(arr));
	}
	private static int[] Conv(int[] arr){
		int index = 0, endEx=arr.Length-1;
		int[] res = new int[arr.Length];
		for(int i = 0; i < arr.Length; i++){
			if(arr[i]%2==0) res[index++]=arr[i];
			else res[endEx--]=arr[i];
		}
		return res;
	}
	private static void PrintArray(int[] arr){
		Console.Write("new array: ");
		foreach(int a in arr)Console.Write(a+" ");
		Console.WriteLine();
	}
}
