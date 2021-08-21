using System;
public class IncompleteRange{
	public static void Main(){

		Console.WriteLine(MissingNos(new int[] {1,3, 5,6,9}));
       		Console.WriteLine(MissingNos(new int[] {0,10}));
        		
	}
	private static int MissingNos(int[] arr){
		
		Array.Sort(arr);

		return (arr[arr.Length-1]-arr[0]+1)-arr.Length;
	}
}
