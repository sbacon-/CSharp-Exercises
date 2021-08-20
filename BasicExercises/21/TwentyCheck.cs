using System;

public class TwentyCheck{
	public static void Main(){
		
		int a,b;

		System.Console.Write("Input first integer: ");
		a = int.Parse(System.Console.ReadLine());
		System.Console.Write("Input second integer: ");
		b = int.Parse(System.Console.ReadLine());

		System.Console.WriteLine((a+b)==20 || a==20 || b==20);

	}
}
