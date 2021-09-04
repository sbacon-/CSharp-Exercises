using System;
public class FirstTwo{
	public static void Main(){
		Console.WriteLine(FT("Hello"));
		Console.WriteLine(FT("Hi"));
		Console.WriteLine(FT("H"));
		Console.WriteLine(FT(""));
	}
	private static string FT(string str){
		if(str.Length<2)return str;
		return str.Substring(0,2);
	}
}

