using System;
public class FirstNOddNumbers{
	public static void Main(){
		int[] arr = {1,2,3,5,7,9,10};
		PrintArray(Conv(arr,3));
	}
	private static int[] Conv(int[] arr, int n){
		int[] res = new int[n];
		int pos = 0;
		for(int i = 0; i<arr.Length; i++){
			if(arr[i]%2!=0)res[pos++]=arr[i];		
			if(pos==n)break;
		}
		return res;
	}
	private static void PrintArray(int[] arr){
		Console.Write("new array: ");
		foreach(int a in arr)Console.Write(a+" ");
		Console.WriteLine();
	}
}
