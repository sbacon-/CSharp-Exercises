using System;

public class ReverseString{
	public static void Main(){
		
		string str;

		System.Console.Write("Input string to reverse: ");
		str=System.Console.ReadLine();

		char[] s = str.ToCharArray();
		Array.Reverse(s);
		System.Console.WriteLine(s);
		
	}
}
