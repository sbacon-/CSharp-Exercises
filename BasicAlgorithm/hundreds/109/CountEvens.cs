using System;
public class CountEvens{
	public static void Main(){
		int[] arr = {1,5,7,9,10,12};
		Console.WriteLine(Evens(arr));	
	}
	private static int Evens(int[] arr){
		int count = 0;
		foreach(int i in arr)if(i%2==0)count++;
		return count;
	}
}
