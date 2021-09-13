using System;
public class ChopStringArray{
	public static void Main(){
		string[] arr = {"a", "b", "bb", "c", "ccc" };
		PrintArray(Chop(arr,3));
	}
	private static string[] Chop(string[] arr, int index){
		string[] res = new string[index];
		for(int i = 0; i < res.Length; i++){
			res[i] = arr[i];
		}
		return res;
	}
	private static void PrintArray(string[] arr){
		Console.Write("new array: ");
		foreach(string s in arr)Console.Write(s+" ");
		Console.WriteLine();
	}
}
