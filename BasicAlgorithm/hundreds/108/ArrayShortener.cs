using System;
public class ArrayShortener{
	public static void Main(){
		int[] arr = {1,5,7,9,11,13};

		PrintArray(Convert(arr));	
	}
	private static int[] Convert(int[] arr){
		if(arr.Length<2)return arr;
		Array.Resize(ref arr,2);
		return arr;
	}
	private static void PrintArray(int[] arr){
		Console.Write("Array: ");
		foreach(int i in arr) Console.Write(i+" ");
		Console.WriteLine();
	}
}
