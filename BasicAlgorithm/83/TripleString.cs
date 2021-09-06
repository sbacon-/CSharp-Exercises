using System;
public class TripleString{
	public static void Main(){
		Console.WriteLine(Convert("abc"));	
		Console.WriteLine(Convert("Python"));	
		Console.WriteLine(Convert("J"));	
	}
	private static string Convert(string s){
		s = s.Length<2? s : s.Substring(0,2);
		return s+s+s;
	}
}
