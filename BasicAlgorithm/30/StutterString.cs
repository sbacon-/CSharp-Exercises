using System;
using System.Text;
public class StutterString{
	public static void Main(){
		
		Console.WriteLine(Stutter("abcd"));
		Console.WriteLine(Stutter("abc"));
		Console.WriteLine(Stutter("a"));
		
	}
	private static string Stutter(string str){

		StringBuilder sb = new StringBuilder();

		for(int i=1; i<=str.Length; i++){

			sb.Append(str.Substring(0,i));
		}
		
		return sb.ToString();
	}
}
