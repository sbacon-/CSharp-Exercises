using System;
public class CombineArrays{
	public static void Main(){
		int[] ar1 = {10,20,30};	
		int[] ar2 = {40,50,60};	
		
		PrintArray(Combine(ar1,ar2));
	}
	private static int[] Combine(int[] ar1, int[] ar2){
		int[] result = new int[ar1.Length+ar2.Length];
		
		int index = 0;

		foreach(int i in ar1)result[index++]=i;
		foreach(int i in ar2)result[index++]=i;
		
		return result;
	}
	private static void PrintArray(int[] arr){
		Console.Write("Array: ");
		foreach(int i in arr)Console.Write(i+" ");
		Console.WriteLine();
	}
}
