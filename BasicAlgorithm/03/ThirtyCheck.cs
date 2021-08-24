using System;
public class ThirtyCheck{
	public static void Main(){
	
		Console.WriteLine(CanThirty(30,0));
		Console.WriteLine(CanThirty(25,5));
		Console.WriteLine(CanThirty(20,30));
		Console.WriteLine(CanThirty(20,25));
		
			
	}
	private static bool CanThirty(int x, int y){
		
		return (x==30 || y==30 || x+y==30);
	}
}
