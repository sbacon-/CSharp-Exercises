using System;
using System.Text;
public class RemoveCharacter{
	public static void Main(){
		Console.WriteLine(RemoveC("xxHxix",'x'));
		Console.WriteLine(RemoveC("abxdddca",'a'));
		Console.WriteLine(RemoveC("xabjbhtrb",'b'));
		
	}
	private static string RemoveC(string str,char c){

		StringBuilder sb = new StringBuilder();

		sb.Append(str[0]);

		for(int i = 1; i<str.Length-1; i++){
			if(str[i]!=c)sb.Append(str[i]);
		}
		sb.Append(str[str.Length-1]);
		
		return sb.ToString();
	}
}
