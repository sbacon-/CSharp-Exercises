using System;
public class MultiplyElementsByThree{
	public static void Main(){
		int[] arr = {1,2,3,4};
		PrintArray(Mult(arr,3));
	}
	private static int[] Mult(int[] arr, int x){
		for(int i = 0; i < arr.Length; i++){
			arr[i]*=x;
		}
		return arr;
	}
	private static void PrintArray(int[] arr){
		Console.Write("new array: ");
		foreach(int i in arr)Console.Write(i+" ");
		Console.WriteLine();
	}
}
