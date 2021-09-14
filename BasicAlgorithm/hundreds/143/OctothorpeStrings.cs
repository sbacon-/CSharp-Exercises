using System;
public class OctothorpeStrings{
	public static void Main(){
		int[] arr = {1,2,3,4};	
		PrintArray(Conv(arr));
	}
	private static string[] Conv(int[] s){
		string[] str = new string[s.Length];
		for(int i = 0; i<s.Length; i++){
			str[i] = "#"+s[i]+"#";
		}
		return str;
	}
	private static void PrintArray(string[] s){
		Console.Write("new array: ");
		foreach(string str in s)Console.Write(str+" ");
		Console.WriteLine();
	}
}
