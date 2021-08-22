using System;
public class TwoDigitSwap{
	public static void Main(){
		
		int x;

		Console.Write("Input a two digit integer: ");
		x=int.Parse(Console.ReadLine());

		Console.WriteLine(x/10<x%10);
	}
}
