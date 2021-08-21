using System;
public class FirstLastEquality{
	public static void Main(){
		int[] arr = {1,2,2,3,3,4,5,6,5,7,7,7,8,8,1};

		System.Console.WriteLine(arr[0]==arr[arr.Length-1]);
	}
}
