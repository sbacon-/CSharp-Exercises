using System;
public class TripleSum{
	public static void Main(){
		int x,y;

		x=1;
		y=2;
		Console.WriteLine(TripSum(x,y));

		x=3;
		y=2;
		Console.WriteLine(TripSum(x,y));

		x=2;
		y=2;
		Console.WriteLine(TripSum(x,y));


	}

	private static int TripSum(int x, int y){
	
		return (x!=y)?x+y:3*(x+y);

	}
}
