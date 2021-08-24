using System;
using System.Text;

public class SwapFirstLast{
	public static void Main(){
		Console.WriteLine(SwapFL("abcd"));
		Console.WriteLine(SwapFL("a"));
		Console.WriteLine(SwapFL("xy"));
	}
	private static string SwapFL(string s){
	
		if(s.Length == 1)return s;
	
		StringBuilder sb = new StringBuilder();
		
		sb.Append(s[s.Length-1]);
		
		if(s.Length > 2){
			sb.Append(s.Substring(1,s.Length-2));
		}		

		sb.Append(s[0]);

		return sb.ToString();
	}
}
