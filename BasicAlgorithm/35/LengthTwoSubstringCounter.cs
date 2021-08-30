using System;
public class LengthTwoSubstringCounter{
	public static void Main(){
		Console.WriteLine(Count("abcdefgh","abijsklm"));
		Console.WriteLine(Count("abcde","osuefrcd"));
		Console.WriteLine(Count("pqrstuvwx","pqkdiewx"));
			
	}
	private static int Count(string s1, string s2){
		int count=0;
		for(int i=0; i<s1.Length-1; i++){
			for(int j=0; j<s2.Length-1;j++){
				if(s1.Substring(i,2)==s2.Substring(j,2))count++;
			}
		}
		return count;
	}
}
