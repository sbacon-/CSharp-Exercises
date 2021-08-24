using System;
public class FiftyOne{
	public static void Main(){
		
		Console.WriteLine(AbsFO(53));
		Console.WriteLine(AbsFO(30));
		Console.WriteLine(AbsFO(51));
		
		
	}
	private static int AbsFO(int x){

		int diff = Math.Abs(51-x);
		return diff * ((x>51)?3:1);
	}
}
