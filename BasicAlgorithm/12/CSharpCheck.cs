using System;
public class CSharpCheck{
	public static void Main(){
		Console.WriteLine(Check("C# Sharp"));
		Console.WriteLine(Check("C#"));
		Console.WriteLine(Check("C++"));
		
	}
	private static bool Check(string str){
		if (str.Length<2) return false;
		
		return str.Substring(0,2)=="C#";
	}
}
