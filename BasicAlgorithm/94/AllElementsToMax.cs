using System;
using System.Linq;
public class AllElementsToMax{
	public static void Main(){
		int[] arr = {10,20,-30,-40};	
		arr = Maximize(arr);
		PrintArray(arr);
	}
	private static int[] Maximize(int[] arr){
		int max = arr.Max();
		for(int i = 0; i<arr.Length; i++){
			arr[i]=max;
		}	
		return arr;
	}
	private static void PrintArray(int[] arr){
		Console.Write("Maximized: ");
		foreach(int a in arr){
			Console.Write(a+" ");
		}
		Console.WriteLine();
	}
}
