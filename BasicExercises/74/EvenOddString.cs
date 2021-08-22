using System;
public class EvenOddString{
	public static void Main(){
		EOString("PHP");
		EOString("JavaScript");
		EOString("Python");
	}
	private static void EOString(string str){
		Console.WriteLine(str.Length%2==0?"Even Length":"Odd Length");
	}
}
