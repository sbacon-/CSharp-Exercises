using System;
public class ReverseArray{
	public static void Main(){
		
		int[] arr = {10,20,-30,-40,50};
		//Array.Reverse(arr); This throws an error when using the latest build of mono	
		
		arr = ReverseArr(arr);
		PrintArray(arr);		
	}
	private static int[] ReverseArr(int[] arr){
		int temp;
		for(int i = 0; i<arr.Length/2; i++){
			temp = arr[i];
			arr[i] = arr[arr.Length-1-i];
			arr[arr.Length-1-i]=temp;
		}
		return arr;
	}

	private static void PrintArray(int[] arr){
		Console.Write("reversed array: ");
		foreach(int a in arr)Console.Write(a+" ");
		Console.WriteLine();
	}
}
