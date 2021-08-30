using System;
public class SumToRange{
	public static void Main(){
		Console.WriteLine(SumRound(12,17));
		Console.WriteLine(SumRound(2,17));
		Console.WriteLine(SumRound(22,17));
		Console.WriteLine(SumRound(20,0));
		
	}
	private static int SumRound(int x, int y){
		int sum = x+y;
		if(sum>=10 && sum <=20)sum=30;
		return sum;
	}
}
