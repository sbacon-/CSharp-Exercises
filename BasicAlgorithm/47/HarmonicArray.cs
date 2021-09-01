using System;
public class HarmonicArray{
	public static void Main(){
		int[] ar1 = {1,2,3};
		Console.WriteLine(Check(ar1));
		int[] ar2 = {4,5,6};
		Console.WriteLine(Check(ar2));
		int[] ar3 = {-1,1,0};
		Console.WriteLine(Check(ar3));	
	}
	private static bool Check(int[] arr){
		return (arr[0] + arr[1] == arr[2])||(arr[0] - arr[1] == arr[2]);
	}
}
