using System;

public class FirstBookend{
	public static void Main(){
		
		string str = "The quick brown fox jumps over the lazy dog.";
		
		System.Console.WriteLine(str.Substring(0,1)+str+str.Substring(0,1));

	}
}
