using System;
public class StringMirror{
	public static void Main(){
		Console.WriteLine(Cat("Hi","Hello"));
		Console.WriteLine(Cat("whats","app"));
	}
	private static string Cat(string s1, string s2){
		return s1+s2+s2+s1;
	}
}
