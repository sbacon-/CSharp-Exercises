using System;
public class UpperLastThree{
	public static void Main(){
		Console.WriteLine(ULT("Python"));
		Console.WriteLine(ULT("Javascript"));
		Console.WriteLine(ULT("JS"));
		Console.WriteLine(ULT("PHP"));
		
	}
	private static string ULT(string str){

		int len = str.Length;
		if (len<=3)return str.ToUpper();

		return str.Substring(0,len-(len-3))+str.Substring(len-3).ToUpper();
	}
}
