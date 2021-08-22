using System;
using System.Text;

public class NonAlphabeticChars{
	public static void Main(){
		
		string t1 = "Py@th12on";
		string t2 = "Python 3.0";
		string t3 = "2^sdfds*^*^jlljdslfnoswje34u230sdfds984";
		
		Console.WriteLine(t1+" --> "+FixStr(t1));
		Console.WriteLine(t2+" --> "+FixStr(t2));
		Console.WriteLine(t3+" --> "+FixStr(t3));

	}
	private static string FixStr(string str){
		
		StringBuilder sb = new StringBuilder("");
		
		char[] arr = str.ToCharArray();
		
		foreach(char a in arr){
			if(a>='A' && a<='Z')sb.Append(a);
			if(a>='a' && a<='z')sb.Append(a);
		}

		return sb.ToString();

	}
}
