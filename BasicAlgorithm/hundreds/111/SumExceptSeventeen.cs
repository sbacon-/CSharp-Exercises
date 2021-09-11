using System;
public class SumExceptSeventeen{
	public static void Main(){
		int[] arr = {1,5,7,9,10,17};
		PrintArray(arr);
		Console.WriteLine("Sum of values in the array of integers except 17: ");
		Console.WriteLine(Sum(arr));
	}
	private static int Sum(int[] arr){
		int sum = 0;
		foreach(int a in arr){
			if (a==17) continue;
			sum+=a;
		}
		return sum;
	}
	private static void PrintArray(int[] arr){
		Console.Write("Original array: ");
		foreach(int a in arr)Console.Write(a+" ");
		Console.WriteLine();
	}
}
