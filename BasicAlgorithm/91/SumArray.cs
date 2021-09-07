using System;
public class SumArray{
	public static void Main(){
		int[] ar1 = {10,20,30,40,50};
		int[] ar2 = {10,20,-30,-40,50};
		Console.WriteLine(Sum(ar1));	
		Console.WriteLine(Sum(ar2));	
	}
	private static int Sum(int[] arr){
		int sum = 0;
		foreach(int i in arr)sum+=i;
		return sum;
	}
}
