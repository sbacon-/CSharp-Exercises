using System;
public class AddTwoTimesFive{
	public static void Main(){
		int[] arr = {1,2,3,4};	

		PrintArray(Conv(arr));
	}
	private static int[] Conv(int[] arr){
		for(int i = 0; i < arr.Length; i++){
			arr[i]+=2;
			arr[i]*=5;
		}
		return arr;
	}
	private static void PrintArray(int[] arr){
		Console.Write("new array: ");
		foreach(int a in arr)Console.Write(a+" ");
		Console.WriteLine();
	}
}
