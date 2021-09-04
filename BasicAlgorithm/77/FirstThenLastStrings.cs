using System;
public class FirstThenLastStrings{
	public static void Main(){
		Console.WriteLine(FLT("Hello","Hi"));
		Console.WriteLine(FLT("Python","PHP"));
		Console.WriteLine(FLT("JS","JS"));
		Console.WriteLine(FLT("Csharp",""));
	}
	private static string FLT(string a, string b){
		if(a.Length == 0 ) a="#";
		if(b.Length == 0 ) b="#";
		
		return a.Substring(0,1)+b.Substring(b.Length-1);
	}
}
