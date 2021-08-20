using System;

public class TrioCalc{
	public static void Main(){

		int x,y,z;

		System.Console.Write("Input x: ");
		x = int.Parse(System.Console.ReadLine());
		System.Console.Write("Input y: ");
		y = int.Parse(System.Console.ReadLine());
		System.Console.Write("Input z: ");
		z = int.Parse(System.Console.ReadLine());
		
		System.Console.WriteLine("(x+y)*z = "+(x+y)*z);
		System.Console.WriteLine("(xy)+(yz) = "+(x*y)+(y*z));
	}
}
