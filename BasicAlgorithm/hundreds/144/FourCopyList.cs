using System;
public class FourCopyList{
	public static void Main(){
		string[] arr = { "1", "2", "3" , "4" };
		PrintArray(Conv(arr));
	}
	private static string[] Conv(string[] arr){
		for(int i = 0; i<arr.Length; i++){
			arr[i]+=arr[i];	
			arr[i]+=arr[i];	
		}
		return arr;
	}
	private static void PrintArray(string[] arr){
		Console.Write("new array: ");
		foreach(string a in arr)Console.Write(a+" ");
		Console.WriteLine();
	}
}
