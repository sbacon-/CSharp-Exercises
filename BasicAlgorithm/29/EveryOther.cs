using System;
using System.Text;
public class EveryOther{
	public static void Main(){
		
		Console.WriteLine(EOString("Python"));
		Console.WriteLine(EOString("PHP"));
		Console.WriteLine(EOString("JS"));
		
	}
	private static string EOString(string str){

		StringBuilder sb = new StringBuilder();

		for(int i = 0; i<str.Length; i+=2){

			sb.Append(str[i]);
		
		}

		return sb.ToString();
		
	}
}
