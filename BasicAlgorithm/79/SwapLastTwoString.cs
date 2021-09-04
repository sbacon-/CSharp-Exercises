using System;
public class SwapLastTwoString{
	public static void Main(){
		Console.WriteLine(SLT("Hello"));	
		Console.WriteLine(SLT("Python"));	
		Console.WriteLine(SLT("PHP"));	
		Console.WriteLine(SLT("JS"));	
		Console.WriteLine(SLT("C"));	
	}
	private static string SLT(string s){
		if(s.Length<2)return s;	
		return s.Substring(0,s.Length-2)+s[s.Length-1]+s[s.Length-2];
	}
}
