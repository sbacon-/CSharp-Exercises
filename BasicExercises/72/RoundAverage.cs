using System;
public class RoundAverage{
	public static void Main(){
		
		int[] nums1 = {1,2,3,5,4,2,3,4};
		int[] nums2 = {2,4,2,6,4,8};

		Console.WriteLine(RoundAvg(nums1));
		Console.WriteLine(RoundAvg(nums2));
	}
	private static bool RoundAvg(int[] arr){
		float avg=0.0f;
		foreach(int a in arr)avg+=(float)a;
		avg/=arr.Length;

		return avg==(int)avg;
	}
}
