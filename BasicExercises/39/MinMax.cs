using System;

public class MinMax{
	public static void Main(){
		
		int x,y,z;

		System.Console.Write("Input first integer: ");
		x=int.Parse(System.Console.ReadLine());
		System.Console.Write("Input second integer: ");
		y=int.Parse(System.Console.ReadLine());
		System.Console.Write("Input third integer: ");
		z=int.Parse(System.Console.ReadLine());

		System.Console.WriteLine("Min: "+((x<y?x:y)<z?(x<y?x:y):z));
		System.Console.WriteLine("Max: "+((x>y?x:y)>z?(x>y?x:y):z));

	}
}
