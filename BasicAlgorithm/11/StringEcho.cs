using System;
public class StringEcho{
	public static void Main(){
	
		Console.WriteLine(Echo("Python"));
		Console.WriteLine(Echo("JS"));
		Console.WriteLine(Echo("Code"));
	
	}
	private static string Echo(string str){
		string echo = (str.Length>2)?str.Substring(0,3):str;

		return echo+str+echo;

	}
}
