using System;
public class MoveToEnd{
	public static void Main(){
		Console.WriteLine(MTE("Hello"));	
		Console.WriteLine(MTE("JS"));	
	}
	private static string MTE(string s){
		
		if(s.Length<=2)return s;

		return s.Substring(2)+s.Substring(0,2);
	}
}
