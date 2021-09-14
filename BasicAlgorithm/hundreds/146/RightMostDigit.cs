using System;
public class RightMostDigit{
	public static void Main(){
		int[] arr = {10,22,35,41};

		PrintArray(Conv(arr));
	}
	private static int[] Conv(int[] arr){
		for(int i = 0; i < arr.Length; i++){
			arr[i]%=10;
		}
		return arr;
	}
	private static void PrintArray(int[] arr){
		Console.Write("new array: ");
		foreach(int a in arr)Console.Write(a+" ");
		Console.WriteLine();
	}
}
