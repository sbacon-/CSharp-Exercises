using System;
public class LastStringLast{
	public static void Main(){
		Console.WriteLine(Surround("Red"));	
		Console.WriteLine(Surround("Green"));	
		Console.WriteLine(Surround("1"));	
	}
	private static string Surround(string str){

		int i = str.Length;		
		return str[i-1]+str+str[i-1];
	}
}
