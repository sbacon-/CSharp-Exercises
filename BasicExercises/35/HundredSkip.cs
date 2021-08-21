using System;

public class HundredSkip{
	public static void Main(){
		
		int x,y;

		System.Console.Write("Input first integer: ");
		x=int.Parse(System.Console.ReadLine());
		System.Console.Write("Input second integer: ");
		y=int.Parse(System.Console.ReadLine());

		System.Console.WriteLine(x<100 && y>100);
		
	}
}
