using System;
public class FirstHalfString{
	public static void Main(){
		Console.WriteLine(FHS("Hello"));
		Console.WriteLine(FHS("Hi"));
	}
	private static string FHS(string str){
		return str.Substring(0,str.Length/2);
	}
}
