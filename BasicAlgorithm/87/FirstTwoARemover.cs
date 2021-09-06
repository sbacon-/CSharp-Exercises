using System;
using System.Text;
public class FirstTwoARemover{
	public static void Main(){
		
		Console.WriteLine(Convert("abcab"));
		Console.WriteLine(Convert("python"));
		Console.WriteLine(Convert("aacda"));
		Console.WriteLine(Convert("jython"));
	}
	private static string Convert(string s){
		StringBuilder sb = new StringBuilder();
		if(s[0]!='a')sb.Append(s[0]);
		if(s[1]!='a')sb.Append(s[1]);
		sb.Append(s.Substring(2));

		return sb.ToString();
	}
}
