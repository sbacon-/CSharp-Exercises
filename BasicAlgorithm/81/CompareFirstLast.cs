using System;
public class CompareFirstLast{
	public static void Main(){
		Console.WriteLine(Check("abab"));
		Console.WriteLine(Check("abcdef"));
		Console.WriteLine(Check("xyzsderxy"));
	}
	private static bool Check(string s){
		return s.Substring(0,2)==s.Substring(s.Length-2);
	}
}
