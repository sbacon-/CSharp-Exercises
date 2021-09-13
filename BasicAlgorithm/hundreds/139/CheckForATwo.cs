using System;
public class CheckForATwo{
	public static void Main(){
		Console.WriteLine(Check(123));
		Console.WriteLine(Check(13));
		Console.WriteLine(Check(222));
	}
	private static bool Check(int num){
		int c = 10;
		while(c<num){
			if(num%c==2)return true;
			num/=c;
		}
		if(num == 2) return true;
		return false;
	}
}
