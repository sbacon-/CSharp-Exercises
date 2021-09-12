using System;
public class PutZerosAtBeginning{
	public static void Main(){
		int[] arr ={ 1, 2, 0, 3, 5, 7, 0, 9, 11 };	
		PrintArray(Shift(arr));
	}
	private static int[] Shift(int[] arr){
		int pos = 0;
		for(int i = 0; i<arr.Length; i++){
			if(arr[i]==0){
				arr[i] = arr [pos];
				arr[pos++]=0;
			}
		}
		return arr;
	}
	private static void PrintArray(int[] arr){
		Console.Write("new array: ");
		foreach(int a in arr)Console.Write(a+" ");
		Console.WriteLine();
	}

}
