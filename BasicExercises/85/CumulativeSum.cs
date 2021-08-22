using System;
public class CumulativeSum{
	public static void Main(){
		double[] nums = {1, 3, 4, 5, 6, 7};
            Console.WriteLine("\nOrginal Array elements: ");
            foreach (var item in nums)
            {
                Console.Write(item.ToString()+" ");
            }
            Console.WriteLine("\nCumulative sum of the said array elements:");
            double[] result = CumSum(nums);
            foreach (var item in result)
            {
                Console.Write(item.ToString()+" ");
            }
		Console.WriteLine("");
            double[] nums1 = { 1.2, -3, 4.1, 6, -5.47 };
            Console.WriteLine("\nOrginal Array elements: ");
            foreach (var item in nums1)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine("\nCumulative sum of the said array elements:");
            double[] result1 = CumSum(nums1);
            foreach (var item in result1)
            {
                Console.Write(item.ToString() + " ");
            }
		Console.WriteLine("");
	}
	private static double[] CumSum(double[] arr){
		double[] result = new double[arr.Length];//Creation of a new array is un-necessary

		result[0]=arr[0];

		for(int i = 1; i<arr.Length; i++){
			result[i]=result[i-1]+arr[i];
		}

		return result;
	}
}
