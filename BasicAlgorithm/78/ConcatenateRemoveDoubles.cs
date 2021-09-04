using System;
using System.Text;
public class ConcatenateRemoveDoubles{
	public static void Main(){
		Console.WriteLine(CCR("abc","cat"));	
		Console.WriteLine(CCR("python","php"));	
		Console.WriteLine(CCR("php","php"));	
	}
	private static string CCR(string a, string b){
		StringBuilder sb = new StringBuilder();
		char prev = ' ';
		foreach(char c in a+b){
			if(c==prev)continue;
			sb.Append(c);
			prev=c;
		}
		return sb.ToString();
	}
}
