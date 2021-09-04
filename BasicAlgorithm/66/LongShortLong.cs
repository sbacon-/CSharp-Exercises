using System;
public class LongShortLong{
	public static void Main(){
		Console.WriteLine(LSL("Hello","Hi"));	
		Console.WriteLine(LSL("JS","Python"));
	}
	private static string LSL(string a, string b){
		return a.Length>b.Length?a+b+a:b+a+b;
	}
}
