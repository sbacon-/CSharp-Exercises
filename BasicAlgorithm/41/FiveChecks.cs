using System;
public class FiveChecks{
	public static void Main(){
		Console.WriteLine(Fives(5,4));
		Console.WriteLine(Fives(4,3));
		Console.WriteLine(Fives(1,4));
		
	}
	private static bool Fives(int x, int y){
		return x==5 || y==5 || x+y==5 || x-y==5;
	}
}
