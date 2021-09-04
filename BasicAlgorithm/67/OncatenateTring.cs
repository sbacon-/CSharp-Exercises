using System;
public class OncatenateTring{
	public static void Main(){
		Console.WriteLine(OS("Hello","Hi"));	
		Console.WriteLine(OS("JS","Python"));	
	}
	private static string OS(string a, string b){
		return a.Substring(1)+b.Substring(1);
	}
}
