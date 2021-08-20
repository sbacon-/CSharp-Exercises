using System;

public class FirstAndLast{
	public static void Main(){
		
		string[] str = {"w3resource","Python","x"};

		foreach (string s in str ) System.Console.WriteLine(FirstLast(s));

	}
	public static string FirstLast(string s){
		
		return s.Length>1?s.Substring(s.Length-1)+s.Substring(1,s.Length-2)+s.Substring(0,1):s;

	}
}

