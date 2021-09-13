using System;
public class FiveIsZeroShiftRight{
	public static void Main(){
		int[] arr = {1,2,5,3,5,7,5,9,11};
		PrintArray(Convert(arr));
	}
	private static int[] Convert(int[] arr){
		return Shift(FZero(arr));
	}
	private static int[] FZero(int[] arr){
		for(int i = 0; i<arr.Length; i++){
			if(arr[i]==5)arr[i]=0;
		}
		return arr;
	}
	private static int[] Shift(int[] arr){
		int pos = arr.Length-1;
		for(int i = arr.Length-1; i>=0; i--){
			if(arr[i]==0){
				arr[i]=arr[pos];
				arr[pos--]=0;
			}
		}
		return arr;
	}
	private static void PrintArray(int[] arr){
		Console.Write("new array: ");
		foreach(int a in arr) Console.Write(a+" ");
		Console.WriteLine();
	}
}
