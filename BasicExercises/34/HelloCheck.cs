using System;

public class HelloCheck{
	public static void Main(){
		
		string str, check = "Hello";

		System.Console.Write("Input a string: ");
		str = System.Console.ReadLine();

		System.Console.WriteLine(
			str.Substring(0,check.Length)==check
		);

	}
}
