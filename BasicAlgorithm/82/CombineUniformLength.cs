using System;
public class CombineUniformLength{
	public static void Main(){
		Console.WriteLine(Combine("abc","abcd"));	
		Console.WriteLine(Combine("Python","Python"));	
		Console.WriteLine(Combine("JS","Python"));	
	}
	private static string Combine(string a, string b){
		if(a.Length>b.Length)a=a.Substring(a.Length-b.Length);
		if(b.Length>a.Length)b=b.Substring(b.Length-a.Length);
		
		return a+b;
	}
}
