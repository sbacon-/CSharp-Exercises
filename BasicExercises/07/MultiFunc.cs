using System;

public class MultiFunc{
	public static void Main(){

		int a,b;

		System.Console.Write("Input first number: ");
		a=int.Parse(System.Console.ReadLine());
		System.Console.Write("Input second number: ");
		b=int.Parse(System.Console.ReadLine());	

		System.Console.WriteLine("a + b = "+(a+b));
		System.Console.WriteLine("a - b = "+(a-b));
		System.Console.WriteLine("a * b = "+(a*b));
		System.Console.WriteLine("a / b = "+(a/b));
		System.Console.WriteLine("a % b = "+(a%b));

	}
}
