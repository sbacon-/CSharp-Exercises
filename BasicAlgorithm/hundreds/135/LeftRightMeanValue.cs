using System;
public class LeftRightMeanValue{
	public static void Main(){
		int[] ar1 = { 1, 2, 3, 4, 6, 8 };
		int[] ar2 = { 15, 2, 3, 4, 15, 11 };

		Console.WriteLine(Check(ar1));
		Console.WriteLine(Check(ar2));
	}
	private static int Check(int[] arr){
		int left = 0, right = 0;
		for(int i = 0; i<arr.Length; i++){
			if(i>=arr.Length/2)right+=arr[i];
			else left += arr[i];
		}
		left /= arr.Length/2;
		right /= arr.Length/2;
		return Math.Max(left,right);
	}
}
