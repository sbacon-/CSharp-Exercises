using System;
public class DoubleCheckRemover{
	public static void Main(){
		
		Console.WriteLine(Check("abcab"));
		Console.WriteLine(Check("Python"));
	}
	private static string Check(string a){
		return a.Substring(0,2)==a.Substring(a.Length-2)?a.Substring(2):a;
	}
}
