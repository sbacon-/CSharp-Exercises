using System;
public class ArraySearch{
	public static void Main(){
		int[] nums = { 1, 3, 5, 7, 9 };
	        int n = 6;
       		Console.WriteLine(SearchArray(n, nums));
           	n = 3;
           	Console.WriteLine(SearchArray(n, nums));
	}
	private static bool SearchArray(int i, int[] arr){
		foreach(int a in arr){
			if(a==i) return true;
		}
		return false;
	}
}
