using System;
public class MiddleOfStringV2{
	public static void Main(){
		Console.WriteLine(MOS("Hello"));
		Console.WriteLine(MOS("JS"));
		Console.WriteLine(MOS(""));
	}
	private static string MOS(string s){
		return s.Length<=2 ? "" : s.Substring(1,s.Length-2);
	}
}
