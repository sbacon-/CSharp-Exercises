using System;
using System.Text;
public class ABookendRemover{
	public static void Main(){
		
		Console.WriteLine(Convert("abcab"));
		Console.WriteLine(Convert("python"));
		Console.WriteLine(Convert("abcda"));
		Console.WriteLine(Convert("jython"));

	}
	private static string Convert(string s){
		StringBuilder sb = new StringBuilder();
		if(s[0]!='a')sb.Append(s[0]);
		sb.Append(s.Substring(1,s.Length-2));
		if(s[s.Length-1]!='a')sb.Append(s[s.Length-1]);

		return sb.ToString();
	}
}
