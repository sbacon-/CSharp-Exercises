using System;
using System.Linq;
public class LargerOfTwoArrays{
	public static void Main(){
		int[] a = {10,20,-30};
		int[] b = {10,20,30};

		PrintArray(Larger(a,b));		
	}
	private static int[] Larger(int[] a, int[] b){
		return a.Sum()>b.Sum()?a:b;
	}
	private static void PrintArray(int[] arr){
		Console.Write("Larger array: ");
		foreach(int a in arr)Console.Write(a+" ");
		Console.WriteLine();
	}
}
