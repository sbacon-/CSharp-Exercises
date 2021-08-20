using System;

public class CloseEnough{
	public static void Main(){
		
		int x;

		System.Console.Write("Input integer: ");
		x = int.Parse(System.Console.ReadLine());

		System.Console.WriteLine(
			Math.Abs(100-x)<=20 ||
			Math.Abs(200-x)<=20
		);

	}
}
