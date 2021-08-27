using System;
using System.Text;

public class StrRepeater{
	public static void Main(){
		Console.WriteLine(Repeat("Python",2));
		Console.WriteLine(Repeat("Python",3));
		Console.WriteLine(Repeat("JS",3));
		
	}
	private static string Repeat(string str, int i){

		if(str.Length>3)str = str.Substring(0,3);
		
		StringBuilder sb = new StringBuilder();
		while(i-->0){

			sb.Append(str);
		}
		return sb.ToString();
	}
}
