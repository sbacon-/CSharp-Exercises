using System;
public class CountZees{
	public static void Main(){
		Console.WriteLine(CountZee("frizz"));
		Console.WriteLine(CountZee("zane"));
		Console.WriteLine(CountZee("Zazz"));
		Console.WriteLine(CountZee("false"));
	}
	private static bool CountZee(string s){

		int count=0;
		char[] str = s.ToCharArray();
		foreach(char a in str){
			if (a=='z' || a=='Z')count++;
			if(count>=2)return true;
		}
		return false;
	}
}
