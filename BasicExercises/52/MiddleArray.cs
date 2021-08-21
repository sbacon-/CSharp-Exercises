using System;
public class MiddleArray{
	public static void Main(){
		
		int[] arr1 = {1,2,5};
		int[] arr2 = {0,3,8};
		int[] arr3 = {-1,0,2};

		int[][] full = {arr1,arr2,arr3};
		foreach(int[] a in full)PrintArray(a);

		int[] result = new int[full.Length];

		for(int i=0; i<full.Length; i++){
			result[i]=full[i][1];
		}

		System.Console.WriteLine();
		PrintArray(result);

	}
	private static void PrintArray(int[] arr){
		System.Console.Write("[ ");
		foreach(int i in arr) System.Console.Write(i+" ");
		System.Console.WriteLine("]");
	}
}
