using System;
using System.Text;
public class FourScore{
	public static void Main(){
		Console.WriteLine(Fourize("Python"));
		Console.WriteLine(Fourize("JavaScript"));
		Console.WriteLine(Fourize("HTML"));
		
	}
	private static string Fourize(string str){

		StringBuilder sb = new StringBuilder();
		for(int i=0; i<str.Length; i+=4){
			sb.Append(str[i]);
			if(i!=str.Length-1)sb.Append(str[i+1]);
		}
		return sb.ToString();
	}
}
