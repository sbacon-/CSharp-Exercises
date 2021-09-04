using System;
public class MoveToFront{
	public static void Main(){
		Console.WriteLine(MTF("Hello"));
		Console.WriteLine(MTF("JS"));

	}
	private static string MTF(string s){
		if(s.Length<=2)return s;
		return s.Substring(s.Length-2)+s.Substring(0,s.Length-2);
	}
}
