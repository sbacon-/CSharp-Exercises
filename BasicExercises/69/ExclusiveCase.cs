using System;
public class ExclusiveCase{
	public static void Main(){
		Console.WriteLine(XCase("PHP"));
	        Console.WriteLine(XCase("python"));
       		Console.WriteLine(XCase("JavaScript"));	
	}
	private static bool XCase(string str){
		return (str==str.ToLower()) || (str==str.ToUpper());
	}
}
