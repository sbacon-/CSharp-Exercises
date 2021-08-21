using System;
public class SumArray{
	public static void Main(){
		
		int[] arr = {1,2,2,3,3,4,5,6,5,7,7,7,8,8,1};

		int sum=0;

		foreach(int i in arr)sum+=i;

		System.Console.WriteLine(sum);

	}
}
