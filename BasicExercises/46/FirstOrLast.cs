using System;
public class FirstOrLast{
	public static void Main(){
		int[] arr = {1,2,2,3,3,4,5,4,6,6,6,8,8,1};

		int x;

		System.Console.Write("Input integer: ");
		x=int.Parse(System.Console.ReadLine());

		System.Console.WriteLine(x==arr[0] || x==arr[arr.Length-1]);

	}
}
