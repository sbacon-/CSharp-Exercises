using System;
public class FirstOrLastDoubleArray{
	public static void Main(){
		int[] arr = {10,20,40,50};	
		int[] ar1 = {10,20,40,50};	
		int[] ar2 = {10,20,40,5};	
		int[] ar3 = {1,20,40,5};	
		Console.WriteLine(Check(arr,ar1));
		Console.WriteLine(Check(arr,ar2));
		Console.WriteLine(Check(arr,ar3));
	}
	private static bool Check(int[] ar1, int[] ar2){
		return (ar1[0]==ar2[0]) || (ar1[ar1.Length-1]==ar2[ar2.Length-1]);
	}
}
