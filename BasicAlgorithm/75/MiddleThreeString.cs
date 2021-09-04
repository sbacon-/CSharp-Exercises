using System;
public class MiddleThreeString{
	public static void Main(){
		Console.WriteLine(MTS("Hello"));	
		Console.WriteLine(MTS("Python"));	
		Console.WriteLine(MTS("abc"));	
	}
	private static string MTS(string s){
		return s.Substring(s.Length/2-1,3);
	}
}
