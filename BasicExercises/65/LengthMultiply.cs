using System;
public class LengthMultiply{
	public static void Main(){
		int[] test = {1,3,5,7,9};

		PrintArray(LenMultiply(test));
	}
	private static int[] LenMultiply(int[] arr){
		
		for(int i = 0; i < arr.Length; i++){
			arr[i] = arr[i]*arr.Length;
		}

		return arr;
	}
	private static void PrintArray(int[] array){
		Console.Write("[ ");
		foreach(int i in array) Console.Write(i+" ");
		Console.WriteLine("]");
	}
}
