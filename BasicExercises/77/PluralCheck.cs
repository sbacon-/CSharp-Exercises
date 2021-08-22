using System;
using System.Linq;

public class PluralCheck{
	public static void Main(){
		Test("Exercise");
		Test("Exercises");
		Test("Books");
		Test("Book");
		Test("Chancho");

	}
	private static bool IsPlural(string str){

		str=str.ToLower();

		char[] arr = str.ToCharArray();

		return arr.Last()=='s';

	}
	private static void Test(string str){
		Console.WriteLine("Is "+str+" plural? "+IsPlural(str));
	}
}
