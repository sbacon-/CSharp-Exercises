using System;
public class CharCount{
	public static void Main(){
		
		Console.WriteLine(CountChar('C',"http://chancho.dev/cSharp/AlgoVisualizer"));
		Console.WriteLine(CountChar('E',"PHP Exercises"));
            	Console.WriteLine(CountChar('a',"Latest News, Breaking News LIVE"));
        
	}
	private static int CountChar(char c, string str){

		int result = 0;
		
		if(c>= 'A' && c<='Z')str=str.ToUpper();
		else str=str.ToLower();

		char[] arr = str.ToCharArray();
		foreach(char a in arr) if (a==c) result++;

		return result;
	}
}
