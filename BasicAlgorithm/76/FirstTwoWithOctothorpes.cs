using System;
public class FirstTwoWithOctothorpes{
	public static void Main(){
		Console.WriteLine(FTO("Hello"));	
		Console.WriteLine(FTO("Python"));	
		Console.WriteLine(FTO("a"));	
		Console.WriteLine(FTO(""));	
	}
	private static string FTO(string s){
		while(s.Length<2)s+="#";
		return s.Substring(0,2);
	}
}
