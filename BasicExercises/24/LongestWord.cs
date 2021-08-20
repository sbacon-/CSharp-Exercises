using System;

public class LongestWord{
	public static void Main(){
		
		string str,max="";

		System.Console.Write("Input string: ");
		str = System.Console.ReadLine();

		foreach(string s in str.Split(' ')){
			if(s.Length > max.Length) max = s;	
		}

		System.Console.WriteLine(max);

	}
}
