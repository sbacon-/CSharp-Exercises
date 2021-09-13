using System;
public class StringsOfLengthArray{
	public static void Main(){
		string[] ar1 = {"a", "aaa", "b", "bbb", "c", "ccc" };
		PrintArray(Conv(ar1,3));
	}
	private static string[] Conv(string[] arr, int l){
		string[] res = new string[Count(arr,l)];
		int pos = 0;
		foreach(string s in arr){
			if(s.Length == l) res[pos++]=s;
		}
		return res;
	}
	private static int Count(string[] arr, int l){
		int count=0;
		foreach(string s in arr){
			if(s.Length == l) count ++;
		}
		return count;
	}
	private static void PrintArray(string[] arr){
		Console.Write("new array: ");
		foreach(string s in arr)Console.Write(s+" ");
		Console.WriteLine();
	}
}
