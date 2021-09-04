using System;
public class FirstLastNCharacters{
	public static void Main(){
		Console.WriteLine(FLN("Hello",1));	
		Console.WriteLine(FLN("Python",2));	
		Console.WriteLine(FLN("on",1));	
		Console.WriteLine(FLN("o",1));	
	}
	private static string FLN(string s, int n){
		return s.Substring(0,n)+s.Substring(s.Length-n);	
	}
}
