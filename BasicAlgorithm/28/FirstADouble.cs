using System;
public class FirstADouble{
	public static void Main(){
		
		Console.WriteLine(ACheck("caabb"));
		Console.WriteLine(ACheck("babaaba"));
		Console.WriteLine(ACheck("aaaaa"));
		
	}
	private static bool ACheck(string s){
		return (s.IndexOf("a")==s.IndexOf("aa"));
	}
}
