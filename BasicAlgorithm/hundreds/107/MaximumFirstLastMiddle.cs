using System;
using System.Linq;
public class MaximumFirstLastMiddle{
	public static void Main(){
		
		int[] ar1 = {1};
		int[] ar2 = {1,2};
		int[] ar3 = {1,2,9};
		int[] ar4 = {1,2,9,3,3};
		int[] ar5 = {1,2,3,4,5,6,7};
		int[] ar6 = {1,2,2,2,3,7,8,9,10,6,5,4};
		Console.WriteLine(FLM(ar1));
		Console.WriteLine(FLM(ar2));
		Console.WriteLine(FLM(ar3));
		Console.WriteLine(FLM(ar4));
		Console.WriteLine(FLM(ar5));
		Console.WriteLine(FLM(ar6));
	}
	private static int FLM(int[] arr){
		int[] flm = {arr[0],arr[arr.Length/2],arr[arr.Length-1]};
		return flm.Max();
	}
}
