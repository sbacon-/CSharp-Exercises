using System;

public class OrGate{
	public static void Main(){
		
		bool result = false;

		int a,b;
		
		System.Console.Write("Input first integer: ");
		a = int.Parse(System.Console.ReadLine());
		System.Console.Write("Input second integer: ");
		b = int.Parse(System.Console.ReadLine());
		
		result = (a>=0 && b<0) || (a<0 && b>=0);

		System.Console.WriteLine(result);

	}
}
