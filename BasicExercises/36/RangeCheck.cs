using System;

public class RangeCheck{
	public static void Main(){
		
		int x,y;

		System.Console.Write("Input first integer: ");
		x=int.Parse(System.Console.ReadLine());
		System.Console.Write("Input second integer: ");
		y=int.Parse(System.Console.ReadLine());

		bool check = true;

		check = x>-10 && x<10;
		check = y>-10 && y<10;

		System.Console.WriteLine(check);

	}
}
