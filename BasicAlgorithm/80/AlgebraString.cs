using System;
public class AlgebraString{
	public static void Main(){
		Console.WriteLine(ALS("abc"));
		Console.WriteLine(ALS("abcdef"));
		Console.WriteLine(ALS("C"));
		Console.WriteLine(ALS("xyz"));
		Console.WriteLine(ALS("xyzsder"));

	}
	private static string ALS(string s){
		if(s.Length<3)return "";	
		if(s.Substring(0,3)=="abc")return "abc";
		if(s.Substring(0,3)=="xyz")return "xyz";
		return "";
	}
}
