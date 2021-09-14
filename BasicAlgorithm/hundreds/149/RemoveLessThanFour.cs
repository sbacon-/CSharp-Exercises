using System;
public class RemoveLessThanFour{ 
	public static void Main(){
		int[] arr ={ 0, -2, 1, 2, 3, 5 , 4, 7, 8 };
		PrintArray(Conv(arr));
	}
	private static int[] Conv(int[] arr){
		//The prompt calls for the removal of values less than four, but the sample answer did the opposite
		//In order to emulate you would just need to change the >= sign to <
		int count = 0;
		foreach(int i in arr) if (i>=4) count++;

		int[] res = new int[count];
		int pos = 0;
		for(int i = 0; i < arr.Length; i++){
			if(arr[i]>=4)res[pos++]=arr[i];
		}
		return res;
	}
	private static void PrintArray(int[] arr){
		Console.Write("new array: ");
		foreach(int a in arr)Console.Write(a+" ");
		Console.WriteLine();
	}
}
