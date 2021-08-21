using System;

public class HPRemove{
	public static void Main(){
		
		string str;

		System.Console.Write("Input a string: ");
		str=System.Console.ReadLine();
		
		System.Console.WriteLine((str.Substring(1,2).Equals("HP")?str.Remove(1,2):str));
	}
}
