using System;
public class FiftySevenMinusSix{
	public static void Main(){
		int[] arr = {1,5,7};
		PrintArray(Convert(arr));	
	}
	private static int[] Convert(int[] arr){
		for(int i = 0; i<arr.Length-1; i++){
			if(arr[i]==5 && arr[i+1]==7)arr[i+1]=1;
		}
		return arr;
	}
	private static void PrintArray(int[] arr){

		Console.Write("Array: ");
		foreach(int i in arr)Console.Write(i+" ");
		
		Console.WriteLine();
	}
}
