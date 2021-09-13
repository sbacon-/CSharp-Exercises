using System;
public class CountStringsOfLength{
	public static void Main(){
		string[] ar1 = {"a", "b", "bb", "c", "ccc" };
		Console.WriteLine(Count(ar1,1));
	}
	private static int Count(string[] arr, int l){
		int count=0;
		foreach(string s in arr){
			if(s.Length == l) count ++;
		}
		return count;
	}
}
