using System;
public class RotateArray{
	public static void Main(){
		int[] arr = {1,2,8};
		PrintArray(arr);	

		int temp = arr[0];

		for(int i=1;i<arr.Length;i++){
			arr[i-1]=arr[i];
		}

		arr[arr.Length-1]=temp;
	
		PrintArray(arr);	
	}
	private static void PrintArray(int[] arr){
		System.Console.Write("Array:[ ");
		foreach(int i in arr)System.Console.Write(i+" ");
		System.Console.WriteLine("]");
	}
}
