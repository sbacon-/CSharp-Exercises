using System;
public class MiddleReturn{
	public static void Main(){
		Console.WriteLine(MidRet("Hell"));

		Console.WriteLine(MidRet("JS"));
	}
	private static string MidRet(string str){
		return str.Substring(str.Length/2-1,2);
	}
}
