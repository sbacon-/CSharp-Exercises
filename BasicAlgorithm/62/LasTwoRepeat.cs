using System;
public class LasTwoRepeat{
	public static void Main(){
		Console.WriteLine(LTR("Hello"));
		Console.WriteLine(LTR("Hi"));
	}
	private static string LTR(string str){
		string s = str.Substring(str.Length-2);	
		return s+s+s; 
	}
}
