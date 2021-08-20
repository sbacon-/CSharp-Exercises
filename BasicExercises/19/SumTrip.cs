using System;

public class SumTrip{
	public static void Main(){
		
		int a,b;

		System.Console.Write("Input first integer: ");
		a=int.Parse(System.Console.ReadLine());
		System.Console.Write("Input second integer: ");
		b=int.Parse(System.Console.ReadLine());
		
		System.Console.WriteLine(a==b?3*(a+b):a+b);
	}
}
