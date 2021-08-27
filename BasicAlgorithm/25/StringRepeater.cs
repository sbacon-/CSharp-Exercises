using System;
using System.Text;
public class StringRepeater{
	public static void Main(){
	
		Console.WriteLine(Repeat("JS",1));
		Console.WriteLine(Repeat("JS",2));
		Console.WriteLine(Repeat("JS",3));
	}
	private static string Repeat(string str, int i){

		StringBuilder sb = new StringBuilder();

		while(i>0){

			sb.Append(str);
			i--;
		}
		
		return sb.ToString();
	}
}
