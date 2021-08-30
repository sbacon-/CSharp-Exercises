using System;
public class EndCount{
	public static void Main(){
		
		Console.WriteLine(Count("abcdsab"));
		Console.WriteLine(Count("abcdabab"));
		Console.WriteLine(Count("abcabdabab"));
		Console.WriteLine(Count("abcabd"));

	}
	private static int Count(string s){
		int len = s.Length;
		if(len<4)return 0;

		int count = 0;
		for(int i=0;i<len-2;i++){
			if(s.Substring(i,2)==s.Substring(len-2))count++;
		}
		
		return count;
	}
}
