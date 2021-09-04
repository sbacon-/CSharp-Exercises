using System;
public class TwoFromNString{
	public static void Main(){
		Console.WriteLine(TFN("Hello",1));
		Console.WriteLine(TFN("Python",2));
		Console.WriteLine(TFN("on",1));

	}
	private static string TFN(string s, int i){
		if(s.Length<i+2)return s;
		return s.Substring(i,2);
	}
}
