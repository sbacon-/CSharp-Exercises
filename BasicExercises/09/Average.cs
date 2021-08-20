using System;

public class Average{
	public static void Main(){

		int a,b,c,d;

		System.Console.Write("Input first number: ");
		a = int.Parse(System.Console.ReadLine());
		System.Console.Write("Input second number: ");
		b = int.Parse(System.Console.ReadLine());
		System.Console.Write("Input thrid number: ");
		c = int.Parse(System.Console.ReadLine());
		System.Console.Write("Input fourth number: ");
		d = int.Parse(System.Console.ReadLine());

		System.Console.WriteLine("Average of "+a+","+b+","+c+","+d+" : "+((a+b+c+d)/4));

	}
}
