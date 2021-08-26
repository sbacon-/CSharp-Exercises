using System;
public class ClosestToHundred{
	public static void Main(){
		Console.WriteLine(Closest(78,95));	
		Console.WriteLine(Closest(95,95));	
		Console.WriteLine(Closest(99,70));	
	}
	private static int Closest(int x, int y){
		int aX=Math.Abs(100-x);
		int aY=Math.Abs(100-y);
		
		if(aX==aY)return 0;

		return (aX<aY)?x:y;
	}
}
