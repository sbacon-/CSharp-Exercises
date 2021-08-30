using System;
public class SequenceOfFives{
	public static void Main(){
		
		int[] ar1 = {5,5,2};
		int[] ar2 = {5,5,2,5,5};
		int[] ar3 = {5,6,2,9};
			
		Console.WriteLine(Count(ar1));
		Console.WriteLine(Count(ar2));
		Console.WriteLine(Count(ar3));
		
	}
	private static int Count(int[] arr){
		int count=0;
		for(int i=0; i<arr.Length-1; i++){
			if(arr[i]==5 && (arr[i+1]==5 || arr[i+1]==6))count++;
		}
		return count;
	}
}
