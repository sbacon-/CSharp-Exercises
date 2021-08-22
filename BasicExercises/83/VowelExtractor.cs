using System;
using System.Text;

public class VowelExtractor{
	public static void Main(){
		
		string t1 = "Python";
		string t2 = "CSharp";
		string t3 = "JavaScript";
		
		Console.WriteLine(t1+" --> "+VowelX(t1));
		Console.WriteLine(t2+" --> "+VowelX(t2));
		Console.WriteLine(t3+" --> "+VowelX(t3));

	}
	private static string VowelX(string str){
		
		StringBuilder sb = new StringBuilder();
		char[] arr = str.ToCharArray();
		
		foreach(char a in arr){
			switch(a){
				case 'A':
				case 'a':
				case 'E':
				case 'e':
				case 'I':
				case 'i':
				case 'O':
				case 'o':
				case 'U':
				case 'u':
					break;
				default:
					sb.Append(a);
					break;
			}
		}

		return sb.ToString();
	}
}
