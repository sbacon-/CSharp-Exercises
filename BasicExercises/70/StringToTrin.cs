using System;
public class StringToTrin{
	public static void Main(){
		Console.WriteLine(Trin("PHP"));
		Console.WriteLine(Trin("Python"));
		Console.WriteLine(Trin("JavaScript"));
	}
	private static string Trin(string str){
		if(str.Length<3)return "";
		return str.Substring(1,str.Length-2);
	}
}
