using System;
public class MaxFL{
	public static void Main(){
		int[] arr = {1,2,5,7,8};
		
		int max = arr[0]>arr[arr.Length-1]?arr[0]:arr[arr.Length-1];

		System.Console.WriteLine("Max value of the array: " + max);

	}
}
