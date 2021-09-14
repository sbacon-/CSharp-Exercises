using System;
using System.Text;
public class RemoveA{
	public static void Main(){
		string[] arr = { "abc", "cdef", "js" , "php" };
		PrintArray(Conv(arr));
	}
	private static string[] Conv(string[] arr){
		for(int i = 0; i<arr.Length; i++){
			arr[i]=Rem(arr[i]);
		}
		return arr;
	}
	private static string Rem(string s){
		StringBuilder sb = new StringBuilder();
		foreach(char c in s.ToCharArray()){
			if(c!='a')sb.Append(c);
		}
		return sb.ToString();
	}
	private static void PrintArray(string[] arr){
		Console.Write("new array: ");
		foreach(string a in arr)Console.Write(a+" ");
		Console.WriteLine();
	}
}
