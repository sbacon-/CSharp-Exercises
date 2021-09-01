using System;
using System.Text;
public class FizzBuzzString{
	public static void Main(){
		Console.WriteLine(FBStr("FizzBuzz"));
		Console.WriteLine(FBStr("Fizz"));
		Console.WriteLine(FBStr("Buzz"));
		Console.WriteLine(FBStr("Founder"));
		Console.WriteLine(FBStr("Fib"));
		Console.WriteLine(FBStr("Lamb"));
		
	}
	private static string FBStr(string str){
		StringBuilder sb = new StringBuilder();	
		if(str[0]=='F'||str[0]=='f')sb.Append("Fizz");
		if(str[str.Length-1]=='B'||str[str.Length-1]=='b')sb.Append("Buzz");
		return sb.ToString().Length==0?str:sb.ToString();	
	}
}
