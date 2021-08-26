using System;
public class TwoRangeCheck{
	public static void Main(){
		Console.WriteLine(CheckTwo(78,95));
		Console.WriteLine(CheckTwo(25,35));
		Console.WriteLine(CheckTwo(40,50));
		Console.WriteLine(CheckTwo(55,60));
	}
	private static bool CheckTwo(int x, int y){
		return CheckTwo(x,y,40,50) || CheckTwo (x,y,50,60);
	}
	private static bool CheckTwo(int x, int y, int l, int u){
		return (x>=l && x<=u) && (y>=l && y<=u);
	}
}
