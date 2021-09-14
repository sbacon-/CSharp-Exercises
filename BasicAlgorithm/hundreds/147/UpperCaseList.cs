using System;
public class UpperCaseList{
	public static void Main(){
		string[] arr = { "Abc", "cdef", "js" , "php" };
		PrintArray(Conv(arr));
	}
	private static string[] Conv(string[] arr){
		for(int i = 0; i<arr.Length; i++){
			arr[i]=arr[i].ToUpper();	
		}
		return arr;
	}
	private static void PrintArray(string[] arr){
		Console.Write("new array: ");
		foreach(string a in arr)Console.Write(a+" ");
		Console.WriteLine();
	}
}
