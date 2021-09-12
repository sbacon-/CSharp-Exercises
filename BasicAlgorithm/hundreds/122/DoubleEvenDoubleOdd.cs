using System;
public class DoubleEvenDoubleOdd{
	public static void Main(){
		int[] ar1 = { 3, 5, 1, 3, 7 };
		int[] ar2 = { 1, 2, 3, 4 };
		int[] ar3 = { 3, 3, 5, 5, 5, 5};
		int[] ar4 = { 2, 4, 5, 6};
		Console.WriteLine(Check(ar1));
		Console.WriteLine(Check(ar2));
		Console.WriteLine(Check(ar3));
		Console.WriteLine(Check(ar4));

	}
	private static bool Check(int[] arr){
		bool even = (arr[0]%2==0);
		bool nextEven;
		for(int i = 1; i<arr.Length; i++){
			nextEven = (arr[i]%2 == 0);
			if (even==nextEven) return true;
			even=nextEven;
		}
		return false;
	}
}
