using System;

public class AbsoluteMadness{
	public static void Main(){
		
		int a,b;

		System.Console.Write("Input first integer: ");
		a=int.Parse(System.Console.ReadLine());
		System.Console.Write("Input second integer: ");
		b=int.Parse(System.Console.ReadLine());

		int abs = Math.Abs(a-b);
		
		System.Console.WriteLine(abs*((a>b)?2:1));

	}
}
