using System;
public class SortString{
	public static void Main(){
		
		Console.WriteLine(SortStr("PHP"));
		Console.WriteLine(SortStr("python"));
		Console.WriteLine(SortStr("javascript"));
		
	}
	private static string SortStr(string str){

		char[] s = str.ToCharArray();

		Array.Sort(s);

		return new string(s);

	}
}
