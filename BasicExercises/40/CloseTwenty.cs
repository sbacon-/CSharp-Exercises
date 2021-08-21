using System;

public class CloseTwenty{
	public static void Main(){
		
		int a,b;

		System.Console.Write("Input first integer: ");
		a=int.Parse(System.Console.ReadLine());
		System.Console.Write("Input second integer: ");
		b=int.Parse(System.Console.ReadLine());
		
		int aAbs = Math.Abs(20-a);	
		int bAbs = Math.Abs(20-b);
		
		if(aAbs<bAbs)Console.WriteLine(a);
		if(aAbs>bAbs)Console.WriteLine(b);
		if(aAbs==bAbs)Console.WriteLine(0);
		
	}
}
