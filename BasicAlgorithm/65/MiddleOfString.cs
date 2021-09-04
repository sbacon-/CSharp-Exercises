using System;
public class MiddleOfString{
	public static void Main(){
		Console.WriteLine(MOS("Hello"));	
		Console.WriteLine(MOS("Hi"));	
		Console.WriteLine(MOS("Python"));	
	}
	private static string MOS(string str){
		return str.Substring(1,str.Length-2);
	}
}
