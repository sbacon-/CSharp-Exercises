using System;
public class YTCheck{
	public static void Main(){
		Console.WriteLine(Check("Python"));
		Console.WriteLine(Check("ytade"));
		Console.WriteLine(Check("jsues"));
			
	}
	private static string Check(string str){
		if(str.Length<3 || str.Substring(1,2)!="yt")return str;
		if(str.Length<4)return str[0]+"";
		return str[0] + str.Substring(3);	
	}
}
