using System;
public class OnChecker{
	public static void Main(){
		Console.WriteLine(OC("Hello"));
		Console.WriteLine(OC("Python"));
		Console.WriteLine(OC("on"));
		Console.WriteLine(OC("o"));

	}
	private static bool OC(string s){
		if(s.Length<2)return false;
		return s.Substring(s.Length-2).ToLower()=="on";
	}
}
