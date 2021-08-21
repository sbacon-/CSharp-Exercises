using System;

public class FourString{
	public static void Main(){
		
		string str;

		System.Console.Write("Input a string: ");
		str=System.Console.ReadLine();

		if(str.Length>=4) str = str.Substring(str.Length-4);

		for(int i=0; i<4; i++)System.Console.Write(str);

		System.Console.WriteLine();

	}
}
