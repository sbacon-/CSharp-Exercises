using System;
public class SumOfSquares{
	public static void Main(){
	
		int[] nums1 = {1,2,3};
		int[] nums2 = {-2,0,3,4};

		Console.WriteLine(SumSquare(nums1));
		Console.WriteLine(SumSquare(nums2));

	}
	private static int SumSquare(int[] arr){

		int sum=0;

		foreach(int a in arr)sum+=(a*a);

		return sum;

	}
}
