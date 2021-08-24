using System;
using System.Text;

public class RemoveCharacter{
	public static void Main(){
		
		string str = "Python";

		Console.WriteLine(RemChar(str,1));
		Console.WriteLine(RemChar(str,0));
		Console.WriteLine(RemChar(str,4));

	}
	private static string RemChar(string str, int index){

		StringBuilder sb = new StringBuilder();
		
		for(int i=0; i<str.Length; i++){

			if(i==index)continue;
			sb.Append(str[i]);

		}	
		
		return sb.ToString();
	
	}
}
