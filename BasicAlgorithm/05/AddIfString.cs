using System;
public class AddIfString{
	public static void Main(){
	
		Console.WriteLine(IfStr("if else"));	
		Console.WriteLine(IfStr("else"));	
	}
	private static string IfStr(string str){
		
		if(str.Length<2)return "if "+str;

		return (str.Substring(0,2)!="if")?"if "+str:str;
	}
}
