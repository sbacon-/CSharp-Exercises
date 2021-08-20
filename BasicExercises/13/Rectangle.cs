using System;

public class Rectangle{
	public static void Main(){

		int x;

		System.Console.Write("Input number: ");
		x = int.Parse(System.Console.ReadLine());

		System.Console.WriteLine(x+""+x+""+x);
		for(int i = 0; i < 3; i++) System.Console.WriteLine(x+" "+x);
		System.Console.WriteLine(x+""+x+""+x);

	}
}
