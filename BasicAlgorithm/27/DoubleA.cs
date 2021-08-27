using System;
public class DoubleA{
	public static void Main(){
		
		Console.WriteLine(Count("bbaaccaag"));
		Console.WriteLine(Count("jjkiaaasew"));
		Console.WriteLine(Count("JSaaakoiaa"));
		
	}
	private static int Count(string str){

		int result=0;
		for(int i=0; i<str.Length-1;i++){

			if(str.Substring(i,2)=="aa")result++;	
		}

		return result;
	}
}
