using System;
public class RotateLeft{
	public static void Main(){
		int[] arr = {10,20,-30,-40};

		arr = ShiftLeft(arr);

		PrintArray(arr);	
	}
	private static int[] ShiftLeft(int[] arr){
		int temp = arr[0];
		for(int i=0; i<arr.Length-1; i++){
			arr[i] = arr[i+1];
		}
		arr[arr.Length-1] = temp;

		return arr;
	}
	private static void PrintArray(int[] arr){
		Console.Write("Rotated array: ");
		foreach(int a in arr){
			Console.Write(a+" ");
		}
		Console.WriteLine();
	}
}
