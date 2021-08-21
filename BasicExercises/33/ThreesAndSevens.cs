using System;

public class ThreesAndSevens{
	public static void Main(){
		
		int x;

		System.Console.Write("Input an integer: ");
		x=int.Parse(System.Console.ReadLine());

		System.Console.WriteLine(x%3==0 || x%7 ==0);

	}
}
