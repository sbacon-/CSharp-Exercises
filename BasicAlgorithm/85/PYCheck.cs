using System;
using System.Text;
public class PYCheck{
	public static void Main(){
		Console.WriteLine(Check("abcab"));	
		Console.WriteLine(Check("python"));	
		Console.WriteLine(Check("press"));	
		Console.WriteLine(Check("jython"));	
	}
	private static string Check(string a){
		
		StringBuilder sb = new StringBuilder();
		if(a[0] == 'p')sb.Append("p");
		if(a[1] == 'y')sb.Append("y");
		sb.Append(a.Substring(2));

		return sb.ToString();
	}
}
